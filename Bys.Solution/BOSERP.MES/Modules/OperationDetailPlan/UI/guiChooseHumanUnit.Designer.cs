namespace BOSERP.Modules.OperationDetailPlan
{
    partial class guiChooseHumanUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseHumanUnit));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_lkeHRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_cmbOperations = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_lkeHRDepartmentRoomGroupItemID = new BOSERP.DepGroupItemPopUpLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_chkSelectAll = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_trlGroupItems = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomID.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbOperations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomGroupItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlGroupItems)).BeginInit();
            this.SuspendLayout();
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
            this.fld_btnClose.Location = new System.Drawing.Point(876, 603);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 4;
            this.fld_btnClose.Text = "Hủy";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_lkeHRDepartmentID
            // 
            this.fld_lkeHRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentID.BOSComment = null;
            this.fld_lkeHRDepartmentID.BOSDataMember = "HRDepartmentID";
            this.fld_lkeHRDepartmentID.BOSDataSource = "HRDepartments";
            this.fld_lkeHRDepartmentID.BOSDescription = null;
            this.fld_lkeHRDepartmentID.BOSError = null;
            this.fld_lkeHRDepartmentID.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentID.BOSFieldParent = "";
            this.fld_lkeHRDepartmentID.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentID.BOSPrivilege = null;
            this.fld_lkeHRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeHRDepartmentID.BOSSelectType = null;
            this.fld_lkeHRDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentID.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentID.Location = new System.Drawing.Point(75, 16);
            this.fld_lkeHRDepartmentID.Name = "fld_lkeHRDepartmentID";
            this.fld_lkeHRDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentID.Properties.ColumnName = null;
            this.fld_lkeHRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Bộ phận")});
            this.fld_lkeHRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeHRDepartmentID.Properties.NullText = "";
            this.fld_lkeHRDepartmentID.Properties.PopupWidth = 40;
            this.fld_lkeHRDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeHRDepartmentID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHRDepartmentID, true);
            this.fld_lkeHRDepartmentID.Size = new System.Drawing.Size(148, 20);
            this.fld_lkeHRDepartmentID.TabIndex = 93;
            this.fld_lkeHRDepartmentID.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(8, 19);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(51, 13);
            this.bosLabel9.TabIndex = 94;
            this.bosLabel9.Tag = "DC";
            this.bosLabel9.Text = "Phòng ban";
            // 
            // fld_lkeHRDepartmentRoomID
            // 
            this.fld_lkeHRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentRoomID.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentRoomID.BOSComment = null;
            this.fld_lkeHRDepartmentRoomID.BOSDataMember = "HRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID.BOSDataSource = "HRDepartmentRooms";
            this.fld_lkeHRDepartmentRoomID.BOSDescription = null;
            this.fld_lkeHRDepartmentRoomID.BOSError = null;
            this.fld_lkeHRDepartmentRoomID.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentRoomID.BOSFieldParent = "fld_lkeHRDepartmentID";
            this.fld_lkeHRDepartmentRoomID.BOSFieldRelation = "FK_HRDepartmentID";
            this.fld_lkeHRDepartmentRoomID.BOSPrivilege = null;
            this.fld_lkeHRDepartmentRoomID.BOSPropertyName = "EditValue";
            this.fld_lkeHRDepartmentRoomID.BOSSelectType = null;
            this.fld_lkeHRDepartmentRoomID.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentRoomID.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentRoomID.Location = new System.Drawing.Point(332, 16);
            this.fld_lkeHRDepartmentRoomID.Name = "fld_lkeHRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRDepartmentRoomID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRDepartmentRoomID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRDepartmentRoomID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentRoomID.Properties.ColumnName = null;
            this.fld_lkeHRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Phòng ban")});
            this.fld_lkeHRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeHRDepartmentRoomID.Properties.NullText = "";
            this.fld_lkeHRDepartmentRoomID.Properties.PopupWidth = 40;
            this.fld_lkeHRDepartmentRoomID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHRDepartmentRoomID, true);
            this.fld_lkeHRDepartmentRoomID.Size = new System.Drawing.Size(148, 20);
            this.fld_lkeHRDepartmentRoomID.TabIndex = 95;
            this.fld_lkeHRDepartmentRoomID.Tag = "DC";
            this.fld_lkeHRDepartmentRoomID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.Fld_lkeHRDepartmentRoomID_QueryPopUp);
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(252, 19);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(39, 13);
            this.bosLabel2.TabIndex = 96;
            this.bosLabel2.Tag = "DC";
            this.bosLabel2.Text = "Bộ phận";
            // 
            // bosLine2
            // 
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_cmbOperations);
            this.bosLine2.Controls.Add(this.bosLabel7);
            this.bosLine2.Controls.Add(this.fld_btnFind);
            this.bosLine2.Controls.Add(this.fld_lkeHRDepartmentRoomGroupItemID);
            this.bosLine2.Controls.Add(this.bosLabel12);
            this.bosLine2.Controls.Add(this.fld_lkeHRDepartmentID);
            this.bosLine2.Controls.Add(this.fld_lkeHRDepartmentRoomID);
            this.bosLine2.Controls.Add(this.bosLabel2);
            this.bosLine2.Controls.Add(this.bosLabel9);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(0, -4);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(951, 68);
            this.bosLine2.TabIndex = 97;
            this.bosLine2.TabStop = false;
            // 
            // fld_cmbOperations
            // 
            this.fld_cmbOperations.Location = new System.Drawing.Point(332, 42);
            this.fld_cmbOperations.MenuManager = this.screenToolbar;
            this.fld_cmbOperations.Name = "fld_cmbOperations";
            this.fld_cmbOperations.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbOperations.Properties.DisplayMember = "MMOperationName";
            this.fld_cmbOperations.Properties.ValueMember = "MMOperationID";
            this.fld_cmbOperations.Size = new System.Drawing.Size(148, 20);
            this.fld_cmbOperations.TabIndex = 103;
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = "";
            this.bosLabel7.BOSDataSource = "";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(252, 45);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(52, 13);
            this.bosLabel7.TabIndex = 102;
            this.bosLabel7.Text = "Công đoạn";
            // 
            // fld_btnFind
            // 
            this.fld_btnFind.BOSComment = null;
            this.fld_btnFind.BOSDataMember = null;
            this.fld_btnFind.BOSDataSource = null;
            this.fld_btnFind.BOSDescription = null;
            this.fld_btnFind.BOSError = null;
            this.fld_btnFind.BOSFieldGroup = null;
            this.fld_btnFind.BOSFieldRelation = null;
            this.fld_btnFind.BOSPrivilege = null;
            this.fld_btnFind.BOSPropertyName = null;
            this.fld_btnFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("fld_btnFind.ImageOptions.Image")));
            this.fld_btnFind.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnFind.Location = new System.Drawing.Point(501, 36);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(73, 26);
            this.fld_btnFind.TabIndex = 97;
            this.fld_btnFind.Click += new System.EventHandler(this.Fld_btnFind_Click);
            // 
            // fld_lkeHRDepartmentRoomGroupItemID
            // 
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSComment = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSDataMember = "HRDepartmentRoomGroupItemID";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSDataSource = "HRDepartmentRoomGroupItems";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSDescription = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSError = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSFieldGroup = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSFieldParent = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSFieldRelation = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSPrivilege = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSPropertyName = "EditValue";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSSelectType = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSSelectTypeValue = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.CurrentDisplayText = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.Location = new System.Drawing.Point(75, 42);
            this.fld_lkeHRDepartmentRoomGroupItemID.Name = "fld_lkeHRDepartmentRoomGroupItemID";
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.ColumnName = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tên")});
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.DisplayMember = "HRDepartmentRoomGroupItemName";
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.NullText = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.ValueMember = "HRDepartmentRoomGroupItemID";
            this.fld_lkeHRDepartmentRoomGroupItemID.Screen = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.Size = new System.Drawing.Size(148, 20);
            this.fld_lkeHRDepartmentRoomGroupItemID.TabIndex = 5;
            this.fld_lkeHRDepartmentRoomGroupItemID.Tag = "DC";
            this.fld_lkeHRDepartmentRoomGroupItemID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.Fld_lkeHRDepartmentRoomGroupItemID_QueryPopUp);
            // 
            // bosLabel12
            // 
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(8, 45);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(12, 13);
            this.bosLabel12.TabIndex = 4;
            this.bosLabel12.Text = "Tổ";
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = null;
            this.fld_btnOK.BOSDataSource = null;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = null;
            this.fld_btnOK.Location = new System.Drawing.Point(795, 603);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(75, 27);
            this.fld_btnOK.TabIndex = 98;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.Fld_btnOK_Click);
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
            this.fld_chkSelectAll.Location = new System.Drawing.Point(15, 607);
            this.fld_chkSelectAll.MenuManager = this.screenToolbar;
            this.fld_chkSelectAll.Name = "fld_chkSelectAll";
            this.fld_chkSelectAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSelectAll.Screen = null;
            this.fld_chkSelectAll.Size = new System.Drawing.Size(86, 19);
            this.fld_chkSelectAll.TabIndex = 99;
            // 
            // fld_trlGroupItems
            // 
            this.fld_trlGroupItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlGroupItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_trlGroupItems.KeyFieldName = "HRDepartmentRoomGroupItemID";
            this.fld_trlGroupItems.Location = new System.Drawing.Point(8, 70);
            this.fld_trlGroupItems.Name = "fld_trlGroupItems";
            this.fld_trlGroupItems.ParentFieldName = "HRDepartmentRoomGroupItemParentID";
            this.fld_trlGroupItems.Size = new System.Drawing.Size(943, 530);
            this.fld_trlGroupItems.TabIndex = 100;
            // 
            // guiChooseHumanUnit
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(956, 634);
            this.ControlBox = true;
            this.Controls.Add(this.fld_trlGroupItems);
            this.Controls.Add(this.fld_chkSelectAll);
            this.Controls.Add(this.fld_btnOK);
            this.Controls.Add(this.bosLine2);
            this.Controls.Add(this.fld_btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "guiChooseHumanUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách nhân công";
            this.Load += new System.EventHandler(this.guiChooseHumanUnit_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.bosLine2, 0);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_chkSelectAll, 0);
            this.Controls.SetChildIndex(this.fld_trlGroupItems, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomID.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbOperations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomGroupItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlGroupItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentRoomID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLine bosLine2;
        private DepGroupItemPopUpLookupEdit fld_lkeHRDepartmentRoomGroupItemID;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSCheckEdit fld_chkSelectAll;
        private DevExpress.XtraEditors.CheckedComboBoxEdit fld_cmbOperations;
        private BOSComponent.BOSLabel bosLabel7;
        private DevExpress.XtraTreeList.TreeList fld_trlGroupItems;
    }
}