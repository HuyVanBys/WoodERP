namespace BOSERP.Modules.DiscountProgram
{
    partial class guiAddProduct
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
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcProductsGridControl = new BOSERP.Modules.DiscountProgram.ICProductsGridControl();
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtICProductNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_bedICProductGroupID = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_lkeFK_ICDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.BOSLabel5 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosCheckEdit1 = new BOSComponent.BOSCheckEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit1.Properties)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(867, 572);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 3;
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
            this.fld_btnApply.Location = new System.Drawing.Point(778, 572);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcProductsGridControl
            // 
            this.fld_dgcProductsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductsGridControl.BOSComment = null;
            this.fld_dgcProductsGridControl.BOSDataMember = null;
            this.fld_dgcProductsGridControl.BOSDataSource = "ICProducts";
            this.fld_dgcProductsGridControl.BOSDescription = null;
            this.fld_dgcProductsGridControl.BOSError = null;
            this.fld_dgcProductsGridControl.BOSFieldGroup = null;
            this.fld_dgcProductsGridControl.BOSFieldRelation = null;
            this.fld_dgcProductsGridControl.BOSGridType = null;
            this.fld_dgcProductsGridControl.BOSPrivilege = null;
            this.fld_dgcProductsGridControl.BOSPropertyName = null;
            this.fld_dgcProductsGridControl.CommodityType = "";
            this.fld_dgcProductsGridControl.Location = new System.Drawing.Point(12, 80);
            this.fld_dgcProductsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProductsGridControl.Name = "fld_dgcProductsGridControl";
            this.fld_dgcProductsGridControl.PrintReport = false;
            this.fld_dgcProductsGridControl.Screen = null;
            this.fld_dgcProductsGridControl.Size = new System.Drawing.Size(938, 486);
            this.fld_dgcProductsGridControl.TabIndex = 2;
            this.fld_dgcProductsGridControl.Tag = "";
            // 
            // fld_btnFind
            // 
            this.fld_btnFind.AllowFocus = false;
            this.fld_btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnFind.BOSComment = null;
            this.fld_btnFind.BOSDataMember = null;
            this.fld_btnFind.BOSDataSource = null;
            this.fld_btnFind.BOSDescription = null;
            this.fld_btnFind.BOSError = null;
            this.fld_btnFind.BOSFieldGroup = null;
            this.fld_btnFind.BOSFieldRelation = null;
            this.fld_btnFind.BOSPrivilege = null;
            this.fld_btnFind.BOSPropertyName = null;
            this.fld_btnFind.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnFind.Location = new System.Drawing.Point(809, 26);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(115, 27);
            this.fld_btnFind.TabIndex = 159;
            this.fld_btnFind.Text = "Tìm kiếm";
            this.fld_btnFind.Click += new System.EventHandler(this.Fld_btnFind_Click);
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.Appearance.Options.UseForeColor = true;
            this.bosGroupControl1.BOSComment = "";
            this.bosGroupControl1.BOSDataMember = "";
            this.bosGroupControl1.BOSDataSource = "";
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = "";
            this.bosGroupControl1.BOSFieldRelation = "";
            this.bosGroupControl1.BOSPrivilege = "";
            this.bosGroupControl1.BOSPropertyName = "";
            this.bosGroupControl1.Controls.Add(this.fld_txtICProductNo);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_bedICProductGroupID);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ICDepartmentID);
            this.bosGroupControl1.Controls.Add(this.BOSLabel5);
            this.bosGroupControl1.Controls.Add(this.BOSLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_btnFind);
            this.bosGroupControl1.Location = new System.Drawing.Point(12, 8);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(938, 66);
            this.bosGroupControl1.TabIndex = 160;
            this.bosGroupControl1.Tag = "";
            this.bosGroupControl1.Text = "Thông tin tìm kiếm";
            // 
            // fld_txtICProductNo
            // 
            this.fld_txtICProductNo.BOSComment = "";
            this.fld_txtICProductNo.BOSDataMember = "";
            this.fld_txtICProductNo.BOSDataSource = "";
            this.fld_txtICProductNo.BOSDescription = null;
            this.fld_txtICProductNo.BOSError = "";
            this.fld_txtICProductNo.BOSFieldGroup = "";
            this.fld_txtICProductNo.BOSFieldRelation = "";
            this.fld_txtICProductNo.BOSPrivilege = "";
            this.fld_txtICProductNo.BOSPropertyName = "Text";
            this.fld_txtICProductNo.Location = new System.Drawing.Point(610, 32);
            this.fld_txtICProductNo.Name = "fld_txtICProductNo";
            this.fld_txtICProductNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNo.Screen = null;
            this.fld_txtICProductNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICProductNo.TabIndex = 165;
            this.fld_txtICProductNo.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(532, 36);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(63, 13);
            this.bosLabel3.TabIndex = 164;
            this.bosLabel3.Text = "Mã sản phẩm";
            // 
            // fld_bedICProductGroupID
            // 
            this.fld_bedICProductGroupID.BOSComment = null;
            this.fld_bedICProductGroupID.BOSDataMember = "";
            this.fld_bedICProductGroupID.BOSDataSource = "ICProductGroups";
            this.fld_bedICProductGroupID.BOSDescription = null;
            this.fld_bedICProductGroupID.BOSError = null;
            this.fld_bedICProductGroupID.BOSFieldGroup = null;
            this.fld_bedICProductGroupID.BOSFieldRelation = null;
            this.fld_bedICProductGroupID.BOSPrivilege = null;
            this.fld_bedICProductGroupID.BOSPropertyName = null;
            this.fld_bedICProductGroupID.Location = new System.Drawing.Point(349, 32);
            this.fld_bedICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_bedICProductGroupID.Name = "fld_bedICProductGroupID";
            this.fld_bedICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedICProductGroupID.Properties.ReadOnly = true;
            this.fld_bedICProductGroupID.Screen = null;
            this.fld_bedICProductGroupID.Size = new System.Drawing.Size(150, 20);
            this.fld_bedICProductGroupID.TabIndex = 161;
            this.fld_bedICProductGroupID.Tag = "DC";
            this.fld_bedICProductGroupID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Fld_bedICProductGroupID_ButtonClick);
            // 
            // fld_lkeFK_ICDepartmentID
            // 
            this.fld_lkeFK_ICDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ICDepartmentID.BOSComment = null;
            this.fld_lkeFK_ICDepartmentID.BOSDataMember = "FK_ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICDepartmentID.BOSDescription = null;
            this.fld_lkeFK_ICDepartmentID.BOSError = null;
            this.fld_lkeFK_ICDepartmentID.BOSFieldGroup = null;
            this.fld_lkeFK_ICDepartmentID.BOSFieldParent = null;
            this.fld_lkeFK_ICDepartmentID.BOSFieldRelation = null;
            this.fld_lkeFK_ICDepartmentID.BOSPrivilege = null;
            this.fld_lkeFK_ICDepartmentID.BOSPropertyName = null;
            this.fld_lkeFK_ICDepartmentID.BOSSelectType = null;
            this.fld_lkeFK_ICDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICDepartmentID.CurrentDisplayText = "";
            this.fld_lkeFK_ICDepartmentID.Location = new System.Drawing.Point(92, 32);
            this.fld_lkeFK_ICDepartmentID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICDepartmentID.Name = "fld_lkeFK_ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICDepartmentID.Properties.ColumnName = null;
            this.fld_lkeFK_ICDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentNo", "Mã ngành hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentName", "Tên ngành hàng")});
            this.fld_lkeFK_ICDepartmentID.Properties.DisplayMember = "ICDepartmentName";
            this.fld_lkeFK_ICDepartmentID.Properties.NullText = "";
            this.fld_lkeFK_ICDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICDepartmentID.Properties.ValueMember = "ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.Screen = null;
            this.fld_lkeFK_ICDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICDepartmentID.TabIndex = 160;
            this.fld_lkeFK_ICDepartmentID.Tag = "";
            // 
            // BOSLabel5
            // 
            this.BOSLabel5.BOSComment = null;
            this.BOSLabel5.BOSDataMember = null;
            this.BOSLabel5.BOSDataSource = null;
            this.BOSLabel5.BOSDescription = null;
            this.BOSLabel5.BOSError = null;
            this.BOSLabel5.BOSFieldGroup = null;
            this.BOSLabel5.BOSFieldRelation = null;
            this.BOSLabel5.BOSPrivilege = null;
            this.BOSLabel5.BOSPropertyName = null;
            this.BOSLabel5.Location = new System.Drawing.Point(14, 36);
            this.BOSLabel5.Name = "BOSLabel5";
            this.BOSLabel5.Screen = null;
            this.BOSLabel5.Size = new System.Drawing.Size(58, 13);
            this.BOSLabel5.TabIndex = 162;
            this.BOSLabel5.Text = "Ngành hàng";
            // 
            // BOSLabel4
            // 
            this.BOSLabel4.BOSComment = null;
            this.BOSLabel4.BOSDataMember = null;
            this.BOSLabel4.BOSDataSource = null;
            this.BOSLabel4.BOSDescription = null;
            this.BOSLabel4.BOSError = null;
            this.BOSLabel4.BOSFieldGroup = null;
            this.BOSLabel4.BOSFieldRelation = null;
            this.BOSLabel4.BOSPrivilege = null;
            this.BOSLabel4.BOSPropertyName = null;
            this.BOSLabel4.Location = new System.Drawing.Point(265, 36);
            this.BOSLabel4.Name = "BOSLabel4";
            this.BOSLabel4.Screen = null;
            this.BOSLabel4.Size = new System.Drawing.Size(54, 13);
            this.BOSLabel4.TabIndex = 163;
            this.BOSLabel4.Text = "Nhóm hàng";
            // 
            // bosCheckEdit1
            // 
            this.bosCheckEdit1.BOSComment = null;
            this.bosCheckEdit1.BOSDataMember = null;
            this.bosCheckEdit1.BOSDataSource = null;
            this.bosCheckEdit1.BOSDescription = null;
            this.bosCheckEdit1.BOSError = null;
            this.bosCheckEdit1.BOSFieldGroup = null;
            this.bosCheckEdit1.BOSFieldRelation = null;
            this.bosCheckEdit1.BOSPrivilege = null;
            this.bosCheckEdit1.BOSPropertyName = null;
            this.bosCheckEdit1.Location = new System.Drawing.Point(12, 576);
            this.bosCheckEdit1.MenuManager = this.screenToolbar;
            this.bosCheckEdit1.Name = "bosCheckEdit1";
            this.bosCheckEdit1.Properties.Caption = "Chọn tất cả";
            this.bosCheckEdit1.Screen = null;
            this.bosCheckEdit1.Size = new System.Drawing.Size(86, 19);
            this.bosCheckEdit1.TabIndex = 161;
            this.bosCheckEdit1.CheckedChanged += new System.EventHandler(this.BosCheckEdit1_CheckedChanged);
            // 
            // guiAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(962, 611);
            this.ControlBox = true;
            this.Controls.Add(this.bosCheckEdit1);
            this.Controls.Add(this.bosGroupControl1);
            this.Controls.Add(this.fld_dgcProductsGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm sản phẩm";
            this.Load += new System.EventHandler(this.guiAddProduct_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcProductsGridControl, 0);
            this.Controls.SetChildIndex(this.bosGroupControl1, 0);
            this.Controls.SetChildIndex(this.bosCheckEdit1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private ICProductsGridControl fld_dgcProductsGridControl;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSButtonEdit fld_bedICProductGroupID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICDepartmentID;
        private BOSComponent.BOSLabel BOSLabel5;
        private BOSComponent.BOSLabel BOSLabel4;
        private BOSComponent.BOSTextBox fld_txtICProductNo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSCheckEdit bosCheckEdit1;
    }
}