namespace BOSERP.Modules.ProductConstant.UI
{
    partial class guiProductAttributeItems
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
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_dgcProductAttributeItems = new ProductAttributeItemsGridControl();
            this.fld_lkeMMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductAttributeItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(507, 472);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSave.TabIndex = 2;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
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
            this.fld_btnCancel.Location = new System.Drawing.Point(588, 472);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dgcProductAttributeItems
            // 
            this.fld_dgcProductAttributeItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductAttributeItems.BOSComment = null;
            this.fld_dgcProductAttributeItems.BOSDataMember = null;
            this.fld_dgcProductAttributeItems.BOSDataSource = "ICProductAttributeItems";
            this.fld_dgcProductAttributeItems.BOSDescription = null;
            this.fld_dgcProductAttributeItems.BOSError = null;
            this.fld_dgcProductAttributeItems.BOSFieldGroup = null;
            this.fld_dgcProductAttributeItems.BOSFieldRelation = null;
            this.fld_dgcProductAttributeItems.BOSGridType = null;
            this.fld_dgcProductAttributeItems.BOSPrivilege = null;
            this.fld_dgcProductAttributeItems.BOSPropertyName = null;
            this.fld_dgcProductAttributeItems.Location = new System.Drawing.Point(3, 32);
            this.fld_dgcProductAttributeItems.MenuManager = this.screenToolbar;
            this.fld_dgcProductAttributeItems.Name = "fld_dgcProductAttributeItems";
            this.fld_dgcProductAttributeItems.PrintReport = false;
            this.fld_dgcProductAttributeItems.Screen = null;
            this.fld_dgcProductAttributeItems.Size = new System.Drawing.Size(660, 434);
            this.fld_dgcProductAttributeItems.TabIndex = 1;
            // 
            // fld_lkeMMOperationID
            // 
            this.fld_lkeMMOperationID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeMMOperationID.BOSAllowAddNew = false;
            this.fld_lkeMMOperationID.BOSAllowDummy = true;
            this.fld_lkeMMOperationID.BOSComment = null;
            this.fld_lkeMMOperationID.BOSDataMember = "MMOperationID";
            this.fld_lkeMMOperationID.BOSDataSource = "MMOperations";
            this.fld_lkeMMOperationID.BOSDescription = null;
            this.fld_lkeMMOperationID.BOSError = null;
            this.fld_lkeMMOperationID.BOSFieldGroup = null;
            this.fld_lkeMMOperationID.BOSFieldParent = null;
            this.fld_lkeMMOperationID.BOSFieldRelation = null;
            this.fld_lkeMMOperationID.BOSPrivilege = null;
            this.fld_lkeMMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeMMOperationID.BOSSelectType = null;
            this.fld_lkeMMOperationID.BOSSelectTypeValue = null;
            this.fld_lkeMMOperationID.CurrentDisplayText = null;
            this.fld_lkeMMOperationID.Location = new System.Drawing.Point(72, 6);
            this.fld_lkeMMOperationID.Name = "fld_lkeMMOperationID";
            this.fld_lkeMMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "Mã công đoạn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên công đoạn")});
            this.fld_lkeMMOperationID.Properties.DisplayMember = "MMOperationNo";
            this.fld_lkeMMOperationID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeMMOperationID.Screen = null;
            this.fld_lkeMMOperationID.Size = new System.Drawing.Size(591, 20);
            this.fld_lkeMMOperationID.TabIndex = 0;
            this.fld_lkeMMOperationID.Tag = "DC";
            this.fld_lkeMMOperationID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeMMOperationID_KeyUp);
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = null;
            this.bosLabel27.BOSDataMember = null;
            this.bosLabel27.BOSDataSource = null;
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = null;
            this.bosLabel27.BOSFieldRelation = null;
            this.bosLabel27.BOSPrivilege = null;
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(12, 9);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel27, true);
            this.bosLabel27.Size = new System.Drawing.Size(52, 13);
            this.bosLabel27.TabIndex = 549;
            this.bosLabel27.Text = "Công đoạn";
            // 
            // guiProductAttributeItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(665, 506);
            this.ControlBox = true;
            this.Controls.Add(this.bosLabel27);
            this.Controls.Add(this.fld_lkeMMOperationID);
            this.Controls.Add(this.fld_dgcProductAttributeItems);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnSave);
            this.Name = "guiProductAttributeItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách công đoạn";
            this.Load += new System.EventHandler(this.guiProductAttributeItems_Load);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcProductAttributeItems, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMOperationID, 0);
            this.Controls.SetChildIndex(this.bosLabel27, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductAttributeItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSButton fld_btnCancel;
        private ProductAttributeItemsGridControl fld_dgcProductAttributeItems;
        private BOSComponent.BOSLookupEdit fld_lkeMMOperationID;
        private BOSComponent.BOSLabel bosLabel27;
    }
}