namespace BOSERP.Modules.ReturnSupplier
{
    partial class guiChooseReceiptItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseReceiptItems));
            this.fld_btnSelect = new BOSComponent.BOSButton(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcReceiptItemsGridControl = new BOSERP.Modules.ReturnSupplier.ICReceiptItemsGridControl();
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.fld_dteSearchToDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.fld_dteSearchFromDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceiptItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnSelect
            // 
            this.fld_btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSelect.BOSComment = null;
            this.fld_btnSelect.BOSDataMember = null;
            this.fld_btnSelect.BOSDataSource = null;
            this.fld_btnSelect.BOSDescription = null;
            this.fld_btnSelect.BOSError = null;
            this.fld_btnSelect.BOSFieldGroup = null;
            this.fld_btnSelect.BOSFieldRelation = null;
            this.fld_btnSelect.BOSPrivilege = null;
            this.fld_btnSelect.BOSPropertyName = null;
            this.fld_btnSelect.Location = new System.Drawing.Point(693, 520);
            this.fld_btnSelect.Name = "fld_btnSelect";
            this.fld_btnSelect.Screen = null;
            this.fld_btnSelect.Size = new System.Drawing.Size(83, 27);
            this.fld_btnSelect.TabIndex = 4;
            this.fld_btnSelect.Text = "Chọn";
            this.fld_btnSelect.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_btnFind
            // 
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
            this.fld_btnFind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnFind.Location = new System.Drawing.Point(766, 12);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(99, 27);
            this.fld_btnFind.TabIndex = 3;
            this.fld_btnFind.Text = "Tìm kiếm";
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
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
            this.fld_btnClose.Location = new System.Drawing.Point(784, 520);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 5;
            this.fld_btnClose.Text = "Hủy";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dgcReceiptItemsGridControl
            // 
            this.fld_dgcReceiptItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcReceiptItemsGridControl.BOSComment = null;
            this.fld_dgcReceiptItemsGridControl.BOSDataMember = null;
            this.fld_dgcReceiptItemsGridControl.BOSDataSource = "ICReceiptItems";
            this.fld_dgcReceiptItemsGridControl.BOSDescription = null;
            this.fld_dgcReceiptItemsGridControl.BOSError = null;
            this.fld_dgcReceiptItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcReceiptItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcReceiptItemsGridControl.BOSGridType = null;
            this.fld_dgcReceiptItemsGridControl.BOSPrivilege = null;
            this.fld_dgcReceiptItemsGridControl.BOSPropertyName = null;
            this.fld_dgcReceiptItemsGridControl.Location = new System.Drawing.Point(12, 54);
            this.fld_dgcReceiptItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcReceiptItemsGridControl.Name = "fld_dgcReceiptItemsGridControl";
            this.fld_dgcReceiptItemsGridControl.PrintReport = false;
            this.fld_dgcReceiptItemsGridControl.Screen = null;
            this.fld_dgcReceiptItemsGridControl.Size = new System.Drawing.Size(855, 457);
            this.fld_dgcReceiptItemsGridControl.TabIndex = 10;
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(95, 16);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 0;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(19, 20);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel11.TabIndex = 472;
            this.fld_lblLabel11.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.Text = "Nhà cung cấp";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(274, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 474;
            this.labelControl2.Text = "Từ ngày";
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(569, 16);
            this.fld_dteSearchToDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.AccessibleName = "ICReceiptDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteSearchToDate.TabIndex = 2;
            this.fld_dteSearchToDate.Tag = "SC";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(509, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 476;
            this.labelControl3.Text = "Đến ngày";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(324, 16);
            this.fld_dteSearchFromDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.AccessibleName = "ICReceiptDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteSearchFromDate.TabIndex = 1;
            this.fld_dteSearchFromDate.Tag = "SC";
            // 
            // guiChooseReceiptItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 556);
            this.ControlBox = true;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.fld_dteSearchToDate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.fld_dteSearchFromDate);
            this.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_dgcReceiptItemsGridControl);
            this.Controls.Add(this.fld_btnSelect);
            this.Controls.Add(this.fld_btnFind);
            this.Controls.Add(this.fld_btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiChooseReceiptItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiến thông tin";
            this.Load += new System.EventHandler(this.guiChooseReceiptItems_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnFind, 0);
            this.Controls.SetChildIndex(this.fld_btnSelect, 0);
            this.Controls.SetChildIndex(this.fld_dgcReceiptItemsGridControl, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACObjectID, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromDate, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToDate, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceiptItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnSelect;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSButton fld_btnClose;
        private ICReceiptItemsGridControl fld_dgcReceiptItemsGridControl;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit fld_dteSearchToDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit fld_dteSearchFromDate;


    }
}