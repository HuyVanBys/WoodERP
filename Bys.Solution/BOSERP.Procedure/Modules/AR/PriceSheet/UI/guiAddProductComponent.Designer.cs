namespace BOSERP.Modules.PriceSheet
{
    partial class guiAddProductComponent
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
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fld_dgcARPriceSheetItemComponentsGridControl = new BOSERP.Modules.PriceSheet.ARPriceSheetItemComponentsGridControl();
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARPriceSheetItemComponentsGridControl)).BeginInit();
            this.SuspendLayout();
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
            this.fld_btnCancel.Location = new System.Drawing.Point(843, 544);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(83, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Thoát";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_lkeFK_ICProductAttributeID
            // 
            this.fld_lkeFK_ICProductAttributeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductAttributeID.BOSDataSource = "ARPriceSheetItems";
            this.fld_lkeFK_ICProductAttributeID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductAttributeID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductAttributeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeID.BOSSelectType = null;
            this.fld_lkeFK_ICProductAttributeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductAttributeID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductAttributeID.Location = new System.Drawing.Point(80, 12);
            this.fld_lkeFK_ICProductAttributeID.Name = "fld_lkeFK_ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID.Screen = null;
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(846, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 11;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductAttributeID_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sản phẩm";
            // 
            // fld_dgcARPriceSheetItemComponentsGridControl
            // 
            this.fld_dgcARPriceSheetItemComponentsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARPriceSheetItemComponentsGridControl.BOSComment = null;
            this.fld_dgcARPriceSheetItemComponentsGridControl.BOSDataMember = null;
            this.fld_dgcARPriceSheetItemComponentsGridControl.BOSDataSource = "ARPriceSheetItems";
            this.fld_dgcARPriceSheetItemComponentsGridControl.BOSDescription = null;
            this.fld_dgcARPriceSheetItemComponentsGridControl.BOSError = null;
            this.fld_dgcARPriceSheetItemComponentsGridControl.BOSFieldGroup = null;
            this.fld_dgcARPriceSheetItemComponentsGridControl.BOSFieldRelation = null;
            this.fld_dgcARPriceSheetItemComponentsGridControl.BOSGridType = null;
            this.fld_dgcARPriceSheetItemComponentsGridControl.BOSPrivilege = null;
            this.fld_dgcARPriceSheetItemComponentsGridControl.BOSPropertyName = null;
            this.fld_dgcARPriceSheetItemComponentsGridControl.Location = new System.Drawing.Point(12, 38);
            this.fld_dgcARPriceSheetItemComponentsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARPriceSheetItemComponentsGridControl.Name = "fld_dgcARPriceSheetItemComponentsGridControl";
            this.fld_dgcARPriceSheetItemComponentsGridControl.PrintReport = false;
            this.fld_dgcARPriceSheetItemComponentsGridControl.Screen = null;
            this.fld_dgcARPriceSheetItemComponentsGridControl.Size = new System.Drawing.Size(914, 500);
            this.fld_dgcARPriceSheetItemComponentsGridControl.TabIndex = 13;
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
            this.fld_btnSave.Location = new System.Drawing.Point(754, 544);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(83, 27);
            this.fld_btnSave.TabIndex = 14;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // guiAddProductComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 583);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnSave);
            this.Controls.Add(this.fld_dgcARPriceSheetItemComponentsGridControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fld_lkeFK_ICProductAttributeID);
            this.Controls.Add(this.fld_btnCancel);
            this.Name = "guiAddProductComponent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.guiAddProduct_Load);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICProductAttributeID, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.fld_dgcARPriceSheetItemComponentsGridControl, 0);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARPriceSheetItemComponentsGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnCancel;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
        private System.Windows.Forms.Label label1;
        private ARPriceSheetItemComponentsGridControl fld_dgcARPriceSheetItemComponentsGridControl;
        private BOSComponent.BOSButton fld_btnSave;
    }
}