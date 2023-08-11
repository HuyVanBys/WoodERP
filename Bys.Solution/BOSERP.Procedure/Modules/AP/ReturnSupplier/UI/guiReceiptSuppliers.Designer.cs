namespace BOSERP.Modules.ReturnSupplier
{
    partial class guiReceiptSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiReceiptSuppliers));
            this.fld_dgcICReceipts = new DevExpress.XtraGrid.GridControl();
            this.fld_dgvICReceipts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gclICReceiptNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclICReceiptDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rplkeProduct = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rplkeICProductAttributes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rplkeICReceiptID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.fld_btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.fld_dteSearchToDate = new DevExpress.XtraEditors.DateEdit();
            this.fld_dteSearchFromDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fld_btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rplkeProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rplkeICProductAttributes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rplkeICReceiptID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcICReceipts
            // 
            this.fld_dgcICReceipts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICReceipts.Location = new System.Drawing.Point(7, 68);
            this.fld_dgcICReceipts.MainView = this.fld_dgvICReceipts;
            this.fld_dgcICReceipts.MenuManager = this.screenToolbar;
            this.fld_dgcICReceipts.Name = "fld_dgcICReceipts";
            this.fld_dgcICReceipts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rplkeProduct,
            this.rplkeICProductAttributes,
            this.rplkeICReceiptID});
            this.fld_dgcICReceipts.Size = new System.Drawing.Size(821, 385);
            this.fld_dgcICReceipts.TabIndex = 7;
            this.fld_dgcICReceipts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICReceipts});
            this.fld_dgcICReceipts.DoubleClick += new System.EventHandler(this.fld_dgcICReceipts_DoubleClick);
            // 
            // fld_dgvICReceipts
            // 
            this.fld_dgvICReceipts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gclICReceiptNo,
            this.gclICReceiptDate});
            this.fld_dgvICReceipts.GridControl = this.fld_dgcICReceipts;
            this.fld_dgvICReceipts.Name = "fld_dgvICReceipts";
            this.fld_dgvICReceipts.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_dgvICReceipts.OptionsView.ShowGroupPanel = false;
            // 
            // gclICReceiptNo
            // 
            this.gclICReceiptNo.Caption = "Mã";
            this.gclICReceiptNo.FieldName = "ICReceiptNo";
            this.gclICReceiptNo.Name = "gclICReceiptNo";
            this.gclICReceiptNo.OptionsColumn.AllowEdit = false;
            this.gclICReceiptNo.Visible = true;
            this.gclICReceiptNo.VisibleIndex = 0;
            this.gclICReceiptNo.Width = 381;
            // 
            // gclICReceiptDate
            // 
            this.gclICReceiptDate.Caption = "Ngày";
            this.gclICReceiptDate.FieldName = "ICReceiptDate";
            this.gclICReceiptDate.Name = "gclICReceiptDate";
            this.gclICReceiptDate.OptionsColumn.AllowEdit = false;
            this.gclICReceiptDate.Visible = true;
            this.gclICReceiptDate.VisibleIndex = 1;
            this.gclICReceiptDate.Width = 384;
            // 
            // rplkeProduct
            // 
            this.rplkeProduct.AutoHeight = false;
            this.rplkeProduct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rplkeProduct.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "No")});
            this.rplkeProduct.DisplayMember = "ICProductName";
            this.rplkeProduct.Name = "rplkeProduct";
            this.rplkeProduct.NullText = "";
            this.rplkeProduct.ValueMember = "ICProductID";
            // 
            // rplkeICProductAttributes
            // 
            this.rplkeICProductAttributes.AutoHeight = false;
            this.rplkeICProductAttributes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rplkeICProductAttributes.Name = "rplkeICProductAttributes";
            this.rplkeICProductAttributes.NullText = "";
            // 
            // rplkeICReceiptID
            // 
            this.rplkeICReceiptID.AutoHeight = false;
            this.rplkeICReceiptID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rplkeICReceiptID.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICReceiptNo", "No"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICReceiptName", "Name")});
            this.rplkeICReceiptID.DisplayMember = "ICReceiptNo";
            this.rplkeICReceiptID.Name = "rplkeICReceiptID";
            this.rplkeICReceiptID.NullText = "";
            this.rplkeICReceiptID.ValueMember = "ICReceiptID";
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSearch.Location = new System.Drawing.Point(728, 37);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Size = new System.Drawing.Size(100, 23);
            this.fld_btnSearch.TabIndex = 4;
            this.fld_btnSearch.Text = "Tìm kiếm";
            this.fld_btnSearch.Click += new System.EventHandler(this.fld_btnSearch_Click);
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(504, 15);
            this.fld_dteSearchToDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.AccessibleName = "ICReceiptDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(100, 20);
            this.fld_dteSearchToDate.TabIndex = 3;
            this.fld_dteSearchToDate.Tag = "SC";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(337, 15);
            this.fld_dteSearchFromDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.AccessibleName = "ICReceiptDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(100, 20);
            this.fld_dteSearchFromDate.TabIndex = 2;
            this.fld_dteSearchFromDate.Tag = "SC";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(473, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Đến";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(270, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Từ ngày";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nhà cung cấp";
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(753, 469);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 23);
            this.fld_btnCancel.TabIndex = 6;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_btnAdd
            // 
            this.fld_btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAdd.Location = new System.Drawing.Point(672, 469);
            this.fld_btnAdd.Name = "fld_btnAdd";
            this.fld_btnAdd.Size = new System.Drawing.Size(75, 23);
            this.fld_btnAdd.TabIndex = 5;
            this.fld_btnAdd.Text = "Chọn";
            this.fld_btnAdd.Click += new System.EventHandler(this.fld_btnAdd_Click);
            // 
            // fld_lkeFK_APSupplierID
            // 
            this.fld_lkeFK_APSupplierID.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID.BOSAllowDummy = true;
            this.fld_lkeFK_APSupplierID.BOSComment = null;
            this.fld_lkeFK_APSupplierID.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_APSupplierID.BOSDescription = null;
            this.fld_lkeFK_APSupplierID.BOSError = null;
            this.fld_lkeFK_APSupplierID.BOSFieldGroup = null;
            this.fld_lkeFK_APSupplierID.BOSFieldParent = null;
            this.fld_lkeFK_APSupplierID.BOSFieldRelation = null;
            this.fld_lkeFK_APSupplierID.BOSPrivilege = null;
            this.fld_lkeFK_APSupplierID.BOSPropertyName = null;
            this.fld_lkeFK_APSupplierID.BOSSelectType = null;
            this.fld_lkeFK_APSupplierID.BOSSelectTypeValue = null;
            this.fld_lkeFK_APSupplierID.CurrentDisplayText = "";
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(92, 15);
            this.fld_lkeFK_APSupplierID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_APSupplierID.Name = "fld_lkeFK_APSupplierID";
            this.fld_lkeFK_APSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Name")});
            this.fld_lkeFK_APSupplierID.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID.Screen = null;
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 8;
            this.fld_lkeFK_APSupplierID.Tag = "SC";
            // 
            // guiReceiptSuppliers
            // 
            this.AcceptButton = this.fld_btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(840, 504);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnAdd);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.fld_dgcICReceipts);
            this.Controls.Add(this.fld_btnSearch);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.fld_dteSearchToDate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.fld_dteSearchFromDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiReceiptSuppliers";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "SS";
            this.Text = "Hoàn trả từ biên nhận";
            this.Load += new System.EventHandler(this.guiReceiptSuppliers_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.guiReceiptSuppliers_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rplkeProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rplkeICProductAttributes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rplkeICReceiptID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit fld_dteSearchToDate;
        private DevExpress.XtraEditors.DateEdit fld_dteSearchFromDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton fld_btnSearch;
        private DevExpress.XtraGrid.GridControl fld_dgcICReceipts;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICReceipts;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rplkeProduct;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rplkeICProductAttributes;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rplkeICReceiptID;
        private DevExpress.XtraGrid.Columns.GridColumn gclICReceiptNo;
        private DevExpress.XtraGrid.Columns.GridColumn gclICReceiptDate;
        private DevExpress.XtraEditors.SimpleButton fld_btnCancel;
        private DevExpress.XtraEditors.SimpleButton fld_btnAdd;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
    }
}