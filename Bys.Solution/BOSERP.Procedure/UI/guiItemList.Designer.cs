namespace BOSERP
{
    partial class guiItemList<T>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiItemList<T>));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fld_dgcICProducts = new BOSERP.ICProductsGridControl();
            this.fld_dgvICProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnSearch = new BOSComponent.BOSButton(this.components);
            this.fld_chkSelectAll = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_bteFK_ICProductGroupID = new BOSComponent.BOSButtonEdit(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bteFK_ICProductGroupID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ngành hàng";
            // 
            // fld_dgcICProducts
            // 
            this.fld_dgcICProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProducts.BOSComment = null;
            this.fld_dgcICProducts.BOSDataMember = null;
            this.fld_dgcICProducts.BOSDataSource = "ICProducts";
            this.fld_dgcICProducts.BOSDescription = null;
            this.fld_dgcICProducts.BOSError = null;
            this.fld_dgcICProducts.BOSFieldGroup = null;
            this.fld_dgcICProducts.BOSFieldRelation = null;
            this.fld_dgcICProducts.BOSGridType = null;
            this.fld_dgcICProducts.BOSPrivilege = null;
            this.fld_dgcICProducts.BOSPropertyName = null;
            this.fld_dgcICProducts.Location = new System.Drawing.Point(2, 69);
            this.fld_dgcICProducts.MainView = this.fld_dgvICProducts;
            this.fld_dgcICProducts.Name = "fld_dgcICProducts";
            this.fld_dgcICProducts.Screen = null;
            this.fld_dgcICProducts.Size = new System.Drawing.Size(865, 466);
            this.fld_dgcICProducts.TabIndex = 1;
            this.fld_dgcICProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICProducts});
            // 
            // fld_dgvICProducts
            // 
            this.fld_dgvICProducts.GridControl = this.fld_dgcICProducts;
            this.fld_dgvICProducts.Name = "fld_dgvICProducts";
            this.fld_dgvICProducts.OptionsDetail.EnableMasterViewMode = false;
            this.fld_dgvICProducts.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // fld_btnAdd
            // 
            this.fld_btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAdd.Location = new System.Drawing.Point(675, 584);
            this.fld_btnAdd.Name = "fld_btnAdd";
            this.fld_btnAdd.Size = new System.Drawing.Size(85, 27);
            this.fld_btnAdd.TabIndex = 4;
            this.fld_btnAdd.Text = "Thêm ";
            this.fld_btnAdd.Click += new System.EventHandler(this.fld_btnAdd_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(772, 584);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Size = new System.Drawing.Size(85, 27);
            this.fld_btnCancel.TabIndex = 5;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.BOSComment = null;
            this.BOSLabel1.BOSDataMember = null;
            this.BOSLabel1.BOSDataSource = null;
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = null;
            this.BOSLabel1.BOSFieldRelation = null;
            this.BOSLabel1.BOSPrivilege = null;
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(273, 12);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(54, 13);
            this.BOSLabel1.TabIndex = 6;
            this.BOSLabel1.Text = "Nhóm hàng";
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.BOSComment = null;
            this.BOSLabel2.BOSDataMember = null;
            this.BOSLabel2.BOSDataSource = null;
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = null;
            this.BOSLabel2.BOSFieldRelation = null;
            this.BOSLabel2.BOSPrivilege = null;
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(527, 12);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(21, 13);
            this.BOSLabel2.TabIndex = 7;
            this.BOSLabel2.Text = "NCC";
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
            this.fld_lkeFK_ICDepartmentID.Location = new System.Drawing.Point(92, 9);
            this.fld_lkeFK_ICDepartmentID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICDepartmentID.Name = "fld_lkeFK_ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.Properties.AccessibleName = "";
            this.fld_lkeFK_ICDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentNo", "Mã ngành hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentName", "Tên ngành hàng")});
            this.fld_lkeFK_ICDepartmentID.Properties.DisplayMember = "ICDepartmentName";
            this.fld_lkeFK_ICDepartmentID.Properties.NullText = "";
            this.fld_lkeFK_ICDepartmentID.Properties.ValueMember = "ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.Screen = null;
            this.fld_lkeFK_ICDepartmentID.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeFK_ICDepartmentID.TabIndex = 8;
            this.fld_lkeFK_ICDepartmentID.Tag = "SC";
            // 
            // fld_lkeFK_APSupplierID
            // 
            this.fld_lkeFK_APSupplierID.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID.BOSAllowDummy = true;
            this.fld_lkeFK_APSupplierID.BOSComment = null;
            this.fld_lkeFK_APSupplierID.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID.BOSDataSource = "ICProducts";
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
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(565, 9);
            this.fld_lkeFK_APSupplierID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_APSupplierID.Name = "fld_lkeFK_APSupplierID";
            this.fld_lkeFK_APSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "Mã NCC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Tên NCC")});
            this.fld_lkeFK_APSupplierID.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APSupplierID.Properties.NullText = "";
            this.fld_lkeFK_APSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID.Screen = null;
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 10;
            this.fld_lkeFK_APSupplierID.Tag = "SC";
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSearch.BOSComment = null;
            this.fld_btnSearch.BOSDataMember = null;
            this.fld_btnSearch.BOSDataSource = null;
            this.fld_btnSearch.BOSDescription = null;
            this.fld_btnSearch.BOSError = null;
            this.fld_btnSearch.BOSFieldGroup = null;
            this.fld_btnSearch.BOSFieldRelation = null;
            this.fld_btnSearch.BOSPrivilege = null;
            this.fld_btnSearch.BOSPropertyName = null;
            this.fld_btnSearch.Location = new System.Drawing.Point(782, 7);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Screen = null;
            this.fld_btnSearch.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSearch.TabIndex = 12;
            this.fld_btnSearch.Text = "Tìm kiếm";
            this.fld_btnSearch.Click += new System.EventHandler(this.fld_btnSearch_Click);
            // 
            // fld_chkSelectAll
            // 
            this.fld_chkSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSelectAll.BOSComment = null;
            this.fld_chkSelectAll.BOSDataMember = null;
            this.fld_chkSelectAll.BOSDataSource = null;
            this.fld_chkSelectAll.BOSDescription = null;
            this.fld_chkSelectAll.BOSError = null;
            this.fld_chkSelectAll.BOSFieldGroup = null;
            this.fld_chkSelectAll.BOSFieldRelation = null;
            this.fld_chkSelectAll.BOSPrivilege = null;
            this.fld_chkSelectAll.BOSPropertyName = null;
            this.fld_chkSelectAll.Location = new System.Drawing.Point(12, 541);
            this.fld_chkSelectAll.MenuManager = this.screenToolbar;
            this.fld_chkSelectAll.Name = "fld_chkSelectAll";
            this.fld_chkSelectAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSelectAll.Screen = null;
            this.fld_chkSelectAll.Size = new System.Drawing.Size(90, 19);
            this.fld_chkSelectAll.TabIndex = 13;
            this.fld_chkSelectAll.CheckedChanged += new System.EventHandler(this.fld_chkSelectAll_CheckedChanged);
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Location = new System.Drawing.Point(2, 564);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(865, 10);
            this.bosLine1.TabIndex = 14;
            this.bosLine1.TabStop = false;
            // 
            // fld_bteFK_ICProductGroupID
            // 
            this.fld_bteFK_ICProductGroupID.BOSComment = null;
            this.fld_bteFK_ICProductGroupID.BOSDataMember = null;
            this.fld_bteFK_ICProductGroupID.BOSDataSource = null;
            this.fld_bteFK_ICProductGroupID.BOSDescription = null;
            this.fld_bteFK_ICProductGroupID.BOSError = null;
            this.fld_bteFK_ICProductGroupID.BOSFieldGroup = null;
            this.fld_bteFK_ICProductGroupID.BOSFieldRelation = null;
            this.fld_bteFK_ICProductGroupID.BOSPrivilege = null;
            this.fld_bteFK_ICProductGroupID.BOSPropertyName = null;
            this.fld_bteFK_ICProductGroupID.Location = new System.Drawing.Point(342, 9);
            this.fld_bteFK_ICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_bteFK_ICProductGroupID.Name = "fld_bteFK_ICProductGroupID";
            this.fld_bteFK_ICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bteFK_ICProductGroupID.Properties.ReadOnly = true;
            this.fld_bteFK_ICProductGroupID.Screen = null;
            this.fld_bteFK_ICProductGroupID.Size = new System.Drawing.Size(160, 20);
            this.fld_bteFK_ICProductGroupID.TabIndex = 15;
            this.fld_bteFK_ICProductGroupID.Tag = "SC";
            this.fld_bteFK_ICProductGroupID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bteFK_ICProductGroupID_ButtonClick);
            // 
            // bosLine2
            // 
            this.bosLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Location = new System.Drawing.Point(2, 49);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(865, 10);
            this.bosLine2.TabIndex = 14;
            this.bosLine2.TabStop = false;
            // 
            // guiItemList
            // 
            this.AcceptButton = this.fld_btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(867, 619);
            this.ControlBox = true;
            this.Controls.Add(this.fld_bteFK_ICProductGroupID);
            this.Controls.Add(this.bosLine2);
            this.Controls.Add(this.bosLine1);
            this.Controls.Add(this.fld_btnSearch);
            this.Controls.Add(this.fld_chkSelectAll);
            this.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.Controls.Add(this.fld_lkeFK_ICDepartmentID);
            this.Controls.Add(this.BOSLabel2);
            this.Controls.Add(this.BOSLabel1);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnAdd);
            this.Controls.Add(this.fld_dgcICProducts);
            this.Controls.Add(this.labelControl1);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiItemList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "SS";
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.guiItemList_Load);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.fld_dgcICProducts, 0);
            this.Controls.SetChildIndex(this.fld_btnAdd, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.BOSLabel1, 0);
            this.Controls.SetChildIndex(this.BOSLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICDepartmentID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_APSupplierID, 0);
            this.Controls.SetChildIndex(this.fld_chkSelectAll, 0);
            this.Controls.SetChildIndex(this.fld_btnSearch, 0);
            this.Controls.SetChildIndex(this.bosLine1, 0);
            this.Controls.SetChildIndex(this.bosLine2, 0);
            this.Controls.SetChildIndex(this.fld_bteFK_ICProductGroupID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bteFK_ICProductGroupID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private ICProductsGridControl fld_dgcICProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICProducts;
        private DevExpress.XtraEditors.SimpleButton fld_btnAdd;
        private DevExpress.XtraEditors.SimpleButton fld_btnCancel;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICDepartmentID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
        private BOSComponent.BOSButton fld_btnSearch;
        private BOSComponent.BOSCheckEdit fld_chkSelectAll;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSButtonEdit fld_bteFK_ICProductGroupID;
        private BOSComponent.BOSLine bosLine2;
    }
}