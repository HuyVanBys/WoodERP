namespace BOSERP.Modules.Report
{
    partial class RP148
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
            this.fld_Line3 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_chkSelectAll = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dgcICRP148Equipment = new BOSERP.Modules.Report.RP148EquipmentsGridControl();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_Line3)).BeginInit();
            this.fld_Line3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICRP148Equipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.bosLine3.SuspendLayout();
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
            this.fld_btnClose.Location = new System.Drawing.Point(632, 420);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 3;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_Line3
            // 
            this.fld_Line3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line3.Appearance.Options.UseBackColor = true;
            this.fld_Line3.Appearance.Options.UseForeColor = true;
            this.fld_Line3.Controls.Add(this.fld_lkeBRBranchID);
            this.fld_Line3.Controls.Add(this.bosLabel3);
            this.fld_Line3.Controls.Add(this.fld_lkeHRDepartmentRoomID);
            this.fld_Line3.Controls.Add(this.bosLabel5);
            this.fld_Line3.Controls.Add(this.fld_dteSearchToDate);
            this.fld_Line3.Controls.Add(this.bosLabel9);
            this.fld_Line3.Controls.Add(this.bosLabel10);
            this.fld_Line3.Controls.Add(this.fld_dteSearchFromDate);
            this.fld_Line3.Dock = System.Windows.Forms.DockStyle.Top;
            this.fld_Line3.Location = new System.Drawing.Point(0, 0);
            this.fld_Line3.Name = "fld_Line3";
            this.fld_Line3.Size = new System.Drawing.Size(719, 82);
            this.fld_Line3.TabIndex = 0;
            this.fld_Line3.Tag = string.Empty;
            // 
            // fld_lkeBRBranchID
            // 
            this.fld_lkeBRBranchID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchID.BOSAllowDummy = true;
            this.fld_lkeBRBranchID.BOSComment = null;
            this.fld_lkeBRBranchID.BOSDataMember = "BRBranchID";
            this.fld_lkeBRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchID.BOSDescription = null;
            this.fld_lkeBRBranchID.BOSError = null;
            this.fld_lkeBRBranchID.BOSFieldGroup = null;
            this.fld_lkeBRBranchID.BOSFieldParent = null;
            this.fld_lkeBRBranchID.BOSFieldRelation = null;
            this.fld_lkeBRBranchID.BOSPrivilege = null;
            this.fld_lkeBRBranchID.BOSPropertyName = null;
            this.fld_lkeBRBranchID.BOSSelectType = null;
            this.fld_lkeBRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeBRBranchID.CurrentDisplayText = null;
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(307, 36);
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 136;
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(242, 39);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 137;
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // fld_lkeHRDepartmentRoomID
            // 
            this.fld_lkeHRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentRoomID.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentRoomID.BOSComment = null;
            this.fld_lkeHRDepartmentRoomID.BOSDataMember = string.Empty;
            this.fld_lkeHRDepartmentRoomID.BOSDataSource = "HRDepartmentRooms";
            this.fld_lkeHRDepartmentRoomID.BOSDescription = null;
            this.fld_lkeHRDepartmentRoomID.BOSError = null;
            this.fld_lkeHRDepartmentRoomID.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentRoomID.BOSFieldParent = null;
            this.fld_lkeHRDepartmentRoomID.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentRoomID.BOSPrivilege = null;
            this.fld_lkeHRDepartmentRoomID.BOSPropertyName = null;
            this.fld_lkeHRDepartmentRoomID.BOSSelectType = null;
            this.fld_lkeHRDepartmentRoomID.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentRoomID.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentRoomID.Location = new System.Drawing.Point(64, 36);
            this.fld_lkeHRDepartmentRoomID.Name = "fld_lkeHRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Phòng ban")});
            this.fld_lkeHRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeHRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID.Screen = null;
            this.fld_lkeHRDepartmentRoomID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRDepartmentRoomID.TabIndex = 134;
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(6, 39);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(51, 13);
            this.bosLabel5.TabIndex = 135;
            this.bosLabel5.Text = "Phòng ban";
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = null;
            this.fld_dteSearchToDate.BOSDataMember = string.Empty;
            this.fld_dteSearchToDate.BOSDataSource = string.Empty;
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = null;
            this.fld_dteSearchToDate.BOSFieldRelation = null;
            this.fld_dteSearchToDate.BOSPrivilege = null;
            this.fld_dteSearchToDate.BOSPropertyName = null;
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(307, 10);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToDate.TabIndex = 2;
            this.fld_dteSearchToDate.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(242, 13);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 2;
            this.bosLabel9.Text = "Đến ngày";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(6, 13);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 0;
            this.bosLabel10.Text = "Từ ngày";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = string.Empty;
            this.fld_dteSearchFromDate.BOSDataSource = string.Empty;
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = null;
            this.fld_dteSearchFromDate.BOSFieldRelation = null;
            this.fld_dteSearchFromDate.BOSPrivilege = null;
            this.fld_dteSearchFromDate.BOSPropertyName = null;
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(64, 10);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromDate.TabIndex = 1;
            this.fld_dteSearchFromDate.Tag = "DC";
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
            this.fld_chkSelectAll.Location = new System.Drawing.Point(6, 287);
            this.fld_chkSelectAll.MenuManager = this.screenToolbar;
            this.fld_chkSelectAll.Name = "fld_chkSelectAll";
            this.fld_chkSelectAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSelectAll.Screen = null;
            this.fld_chkSelectAll.Size = new System.Drawing.Size(81, 19);
            this.fld_chkSelectAll.TabIndex = 16;
            this.fld_chkSelectAll.CheckedChanged += new System.EventHandler(this.fld_chkSelectAll_CheckedChanged);
            // 
            // fld_lkeICProductID
            // 
            this.fld_lkeICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeICProductID.BOSAllowAddNew = false;
            this.fld_lkeICProductID.BOSAllowDummy = false;
            this.fld_lkeICProductID.BOSComment = null;
            this.fld_lkeICProductID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductID.BOSDescription = null;
            this.fld_lkeICProductID.BOSError = null;
            this.fld_lkeICProductID.BOSFieldGroup = null;
            this.fld_lkeICProductID.BOSFieldParent = null;
            this.fld_lkeICProductID.BOSFieldRelation = null;
            this.fld_lkeICProductID.BOSPrivilege = null;
            this.fld_lkeICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeICProductID.BOSSelectTypeValue = "Equipment";
            this.fld_lkeICProductID.CurrentDisplayText = null;
            this.fld_lkeICProductID.Location = new System.Drawing.Point(6, 20);
            this.fld_lkeICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductID.Name = "fld_lkeICProductID";
            this.fld_lkeICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductDesc";
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.fld_lkeICProductID.Size = new System.Drawing.Size(709, 20);
            this.fld_lkeICProductID.TabIndex = 0;
            this.fld_lkeICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeICProductID_KeyUp);
            // 
            // fld_dgcICRP148Equipment
            // 
            this.fld_dgcICRP148Equipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICRP148Equipment.BOSComment = null;
            this.fld_dgcICRP148Equipment.BOSDataMember = null;
            this.fld_dgcICRP148Equipment.BOSDataSource = "ICProducts";
            this.fld_dgcICRP148Equipment.BOSDescription = null;
            this.fld_dgcICRP148Equipment.BOSError = null;
            this.fld_dgcICRP148Equipment.BOSFieldGroup = null;
            this.fld_dgcICRP148Equipment.BOSFieldRelation = null;
            this.fld_dgcICRP148Equipment.BOSGridType = null;
            this.fld_dgcICRP148Equipment.BOSPrivilege = null;
            this.fld_dgcICRP148Equipment.BOSPropertyName = null;
            this.fld_dgcICRP148Equipment.Location = new System.Drawing.Point(5, 41);
            this.fld_dgcICRP148Equipment.Name = "fld_dgcICRP148Equipment";
            this.fld_dgcICRP148Equipment.PrintReport = false;
            this.fld_dgcICRP148Equipment.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.fld_dgcICRP148Equipment.Screen = null;
            this.fld_dgcICRP148Equipment.Size = new System.Drawing.Size(710, 238);
            this.fld_dgcICRP148Equipment.TabIndex = 1;
            this.fld_dgcICRP148Equipment.Tag = "DC";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn1.Name = "gridColumn1";
            // 
            // bosLine3
            // 
            this.bosLine3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine3.BackColor = System.Drawing.Color.Transparent;
            this.bosLine3.BOSComment = string.Empty;
            this.bosLine3.BOSDataMember = string.Empty;
            this.bosLine3.BOSDataSource = string.Empty;
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = string.Empty;
            this.bosLine3.BOSFieldRelation = string.Empty;
            this.bosLine3.BOSPrivilege = string.Empty;
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.fld_chkSelectAll);
            this.bosLine3.Controls.Add(this.fld_lkeICProductID);
            this.bosLine3.Controls.Add(this.fld_dgcICRP148Equipment);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine3.Location = new System.Drawing.Point(0, 88);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(719, 312);
            this.bosLine3.TabIndex = 1;
            this.bosLine3.TabStop = false;
            this.bosLine3.Tag = string.Empty;
            this.bosLine3.Text = "Chọn sản phẩm";
            // 
            // bosButton1
            // 
            this.bosButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bosButton1.Location = new System.Drawing.Point(522, 420);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(75, 27);
            this.bosButton1.TabIndex = 6;
            this.bosButton1.Text = "In";
            this.bosButton1.Click += new System.EventHandler(this.fld_btnPrint_Click);
            // 
            // RP148
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(719, 455);
            this.ControlBox = true;
            this.Controls.Add(this.bosButton1);
            this.Controls.Add(this.fld_Line3);
            this.Controls.Add(this.bosLine3);
            this.Controls.Add(this.fld_btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP148";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thẻ công cụ dụng cụ";
            this.Load += new System.EventHandler(this.RP148_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.bosLine3, 0);
            this.Controls.SetChildIndex(this.fld_Line3, 0);
            this.Controls.SetChildIndex(this.bosButton1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_Line3)).EndInit();
            this.fld_Line3.ResumeLayout(false);
            this.fld_Line3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICRP148Equipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.bosLine3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private DevExpress.XtraEditors.PanelControl fld_Line3;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private RP148EquipmentsGridControl fld_dgcICRP148Equipment;
        private BOSComponent.BOSCheckEdit fld_chkSelectAll;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private ItemLookupEdit fld_lkeICProductID;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentRoomID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSButton bosButton1;
    }
}