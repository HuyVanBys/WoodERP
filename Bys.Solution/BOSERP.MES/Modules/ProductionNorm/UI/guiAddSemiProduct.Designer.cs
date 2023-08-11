namespace BOSERP.Modules.ProductionNorm.UI
{
    partial class guiAddSemiProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiAddSemiProduct));
            this.fld_dgcSemiProductParent = new BOSERP.Modules.ProductionNorm.SemiProductParentsGridControl();
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductID1 = new BOSERP.ItemLookupEdit(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddGroup = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddNew = new BOSComponent.BOSButton(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcSemiProductChild = new BOSERP.Modules.ProductionNorm.SemiProductChildsGridControl();
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddPiece = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSemiProductParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSemiProductChild)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcSemiProductParent
            // 
            this.fld_dgcSemiProductParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSemiProductParent.BOSComment = null;
            this.fld_dgcSemiProductParent.BOSDataMember = null;
            this.fld_dgcSemiProductParent.BOSDataSource = "ICProducts";
            this.fld_dgcSemiProductParent.BOSDescription = null;
            this.fld_dgcSemiProductParent.BOSError = null;
            this.fld_dgcSemiProductParent.BOSFieldGroup = null;
            this.fld_dgcSemiProductParent.BOSFieldRelation = null;
            this.fld_dgcSemiProductParent.BOSGridType = null;
            this.fld_dgcSemiProductParent.BOSPrivilege = null;
            this.fld_dgcSemiProductParent.BOSPropertyName = null;
            this.fld_dgcSemiProductParent.Location = new System.Drawing.Point(3, 25);
            this.fld_dgcSemiProductParent.MenuManager = this.screenToolbar;
            this.fld_dgcSemiProductParent.Name = "fld_dgcSemiProductParent";
            this.fld_dgcSemiProductParent.PrintReport = false;
            this.fld_dgcSemiProductParent.Screen = null;
            this.fld_dgcSemiProductParent.Size = new System.Drawing.Size(988, 152);
            this.fld_dgcSemiProductParent.TabIndex = 0;
            this.fld_dgcSemiProductParent.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(6, 15);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(89, 13);
            this.bosLabel4.TabIndex = 399;
            this.bosLabel4.Text = "Thuộc thành phẩm";
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
            this.fld_lkeICProductID1.Location = new System.Drawing.Point(101, 12);
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
            this.fld_lkeICProductID1.Size = new System.Drawing.Size(281, 20);
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
            this.bosButton2.Location = new System.Drawing.Point(877, 5);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(86, 27);
            this.bosButton2.TabIndex = 5;
            this.bosButton2.Text = "Thoát";
            // 
            // fld_btnAddGroup
            // 
            this.fld_btnAddGroup.BOSComment = null;
            this.fld_btnAddGroup.BOSDataMember = null;
            this.fld_btnAddGroup.BOSDataSource = null;
            this.fld_btnAddGroup.BOSDescription = null;
            this.fld_btnAddGroup.BOSError = null;
            this.fld_btnAddGroup.BOSFieldGroup = null;
            this.fld_btnAddGroup.BOSFieldRelation = null;
            this.fld_btnAddGroup.BOSPrivilege = null;
            this.fld_btnAddGroup.BOSPropertyName = null;
            this.fld_btnAddGroup.Location = new System.Drawing.Point(417, 5);
            this.fld_btnAddGroup.Name = "fld_btnAddGroup";
            this.fld_btnAddGroup.Screen = null;
            this.fld_btnAddGroup.Size = new System.Drawing.Size(86, 27);
            this.fld_btnAddGroup.TabIndex = 1;
            this.fld_btnAddGroup.Text = "Thêm cụm";
            this.fld_btnAddGroup.Click += new System.EventHandler(this.fld_btnAddGroup_Click);
            // 
            // fld_btnAddNew
            // 
            this.fld_btnAddNew.BOSComment = null;
            this.fld_btnAddNew.BOSDataMember = null;
            this.fld_btnAddNew.BOSDataSource = null;
            this.fld_btnAddNew.BOSDescription = null;
            this.fld_btnAddNew.BOSError = null;
            this.fld_btnAddNew.BOSFieldGroup = null;
            this.fld_btnAddNew.BOSFieldRelation = null;
            this.fld_btnAddNew.BOSPrivilege = null;
            this.fld_btnAddNew.BOSPropertyName = null;
            this.fld_btnAddNew.Location = new System.Drawing.Point(509, 5);
            this.fld_btnAddNew.Name = "fld_btnAddNew";
            this.fld_btnAddNew.Screen = null;
            this.fld_btnAddNew.Size = new System.Drawing.Size(86, 27);
            this.fld_btnAddNew.TabIndex = 2;
            this.fld_btnAddNew.Text = "Thêm CT";
            this.fld_btnAddNew.Click += new System.EventHandler(this.fld_btnAddNew_Click);
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
            this.fld_btnSave.Location = new System.Drawing.Point(693, 5);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(86, 27);
            this.fld_btnSave.TabIndex = 3;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(6, 38);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.bosLabel1);
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_dgcSemiProductParent);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_dgcSemiProductChild);
            this.splitContainerControl1.Panel2.Controls.Add(this.bosLabel2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(998, 470);
            this.splitContainerControl1.SplitterPosition = 181;
            this.splitContainerControl1.TabIndex = 400;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(6, 7);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(85, 13);
            this.bosLabel1.TabIndex = 400;
            this.bosLabel1.Text = "Danh sách cụm";
            // 
            // fld_dgcSemiProductChild
            // 
            this.fld_dgcSemiProductChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSemiProductChild.BOSComment = null;
            this.fld_dgcSemiProductChild.BOSDataMember = null;
            this.fld_dgcSemiProductChild.BOSDataSource = "ICProducts";
            this.fld_dgcSemiProductChild.BOSDescription = null;
            this.fld_dgcSemiProductChild.BOSError = null;
            this.fld_dgcSemiProductChild.BOSFieldGroup = null;
            this.fld_dgcSemiProductChild.BOSFieldRelation = null;
            this.fld_dgcSemiProductChild.BOSGridType = null;
            this.fld_dgcSemiProductChild.BOSPrivilege = null;
            this.fld_dgcSemiProductChild.BOSPropertyName = null;
            this.fld_dgcSemiProductChild.Location = new System.Drawing.Point(3, 23);
            this.fld_dgcSemiProductChild.MenuManager = this.screenToolbar;
            this.fld_dgcSemiProductChild.Name = "fld_dgcSemiProductChild";
            this.fld_dgcSemiProductChild.PrintReport = false;
            this.fld_dgcSemiProductChild.Screen = null;
            this.fld_dgcSemiProductChild.Size = new System.Drawing.Size(988, 253);
            this.fld_dgcSemiProductChild.TabIndex = 0;
            this.fld_dgcSemiProductChild.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(6, 4);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(100, 13);
            this.bosLabel2.TabIndex = 401;
            this.bosLabel2.Text = "Danh sách chi tiết";
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
            this.fld_btnCancel.Location = new System.Drawing.Point(785, 5);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(86, 27);
            this.fld_btnCancel.TabIndex = 4;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_btnAddPiece
            // 
            this.fld_btnAddPiece.BOSComment = null;
            this.fld_btnAddPiece.BOSDataMember = null;
            this.fld_btnAddPiece.BOSDataSource = null;
            this.fld_btnAddPiece.BOSDescription = null;
            this.fld_btnAddPiece.BOSError = null;
            this.fld_btnAddPiece.BOSFieldGroup = null;
            this.fld_btnAddPiece.BOSFieldRelation = null;
            this.fld_btnAddPiece.BOSPrivilege = null;
            this.fld_btnAddPiece.BOSPropertyName = null;
            this.fld_btnAddPiece.Location = new System.Drawing.Point(601, 5);
            this.fld_btnAddPiece.Name = "fld_btnAddPiece";
            this.fld_btnAddPiece.Screen = null;
            this.fld_btnAddPiece.Size = new System.Drawing.Size(86, 27);
            this.fld_btnAddPiece.TabIndex = 401;
            this.fld_btnAddPiece.Text = "Thêm CT rời";
            this.fld_btnAddPiece.Click += new System.EventHandler(this.fld_btnAddPiece_Click);
            // 
            // guiAddSemiProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 511);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnAddPiece);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeICProductID1);
            this.Controls.Add(this.bosButton2);
            this.Controls.Add(this.fld_btnAddGroup);
            this.Controls.Add(this.fld_btnAddNew);
            this.Controls.Add(this.fld_btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiAddSemiProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Thêm Cụm / Chi tiết";
            this.Load += new System.EventHandler(this.guiAddSemiProduct_Load);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            this.Controls.SetChildIndex(this.fld_btnAddNew, 0);
            this.Controls.SetChildIndex(this.fld_btnAddGroup, 0);
            this.Controls.SetChildIndex(this.bosButton2, 0);
            this.Controls.SetChildIndex(this.fld_lkeICProductID1, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_btnAddPiece, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSemiProductParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSemiProductChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SemiProductParentsGridControl fld_dgcSemiProductParent;
        private BOSComponent.BOSLabel bosLabel4;
        private ItemLookupEdit fld_lkeICProductID1;
        private BOSComponent.BOSButton bosButton2;
        private BOSComponent.BOSButton fld_btnAddGroup;
        private BOSComponent.BOSButton fld_btnAddNew;
        private BOSComponent.BOSButton fld_btnSave;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private SemiProductChildsGridControl fld_dgcSemiProductChild;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSButton fld_btnAddPiece;
    }
}