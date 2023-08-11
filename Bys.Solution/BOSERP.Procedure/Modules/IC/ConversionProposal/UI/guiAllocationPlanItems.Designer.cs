namespace BOSERP.Modules.ConversionProposal
{
    partial class guiAllocationPlanItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiAllocationPlanItems));
            this.fld_btnSelect = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMAllocationPlanItemsGridControl = new BOSERP.Modules.ConversionProposal.MMAllocationPlanItemsGridControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_btnShowInventoryStock = new BOSComponent.BOSButton(this.components);
            this.fld_lkeHRDepartmentRoomGroupItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeIDReceive = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMLineID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMAllocationPlanID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMAllocationPlanItemsGridControl)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomGroupItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeIDReceive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMAllocationPlanID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
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
            this.fld_btnSelect.Location = new System.Drawing.Point(1137, 671);
            this.fld_btnSelect.Name = "fld_btnSelect";
            this.fld_btnSelect.Screen = null;
            this.fld_btnSelect.Size = new System.Drawing.Size(83, 27);
            this.fld_btnSelect.TabIndex = 0;
            this.fld_btnSelect.Text = "Chọn";
            this.fld_btnSelect.Click += new System.EventHandler(this.fld_btnOK_Click);
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
            this.fld_btnClose.Location = new System.Drawing.Point(1228, 671);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 1;
            this.fld_btnClose.Text = "Hủy";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dgcMMAllocationPlanItemsGridControl
            // 
            this.fld_dgcMMAllocationPlanItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSComment = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSDataMember = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSDataSource = "MMAllocationPlanItems";
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSDescription = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSError = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSGridType = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSPrivilege = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSPropertyName = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.CommodityType = "";
            this.fld_dgcMMAllocationPlanItemsGridControl.Location = new System.Drawing.Point(12, 94);
            this.fld_dgcMMAllocationPlanItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcMMAllocationPlanItemsGridControl.Name = "fld_dgcMMAllocationPlanItemsGridControl";
            this.fld_dgcMMAllocationPlanItemsGridControl.PrintReport = false;
            this.fld_dgcMMAllocationPlanItemsGridControl.Screen = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.Size = new System.Drawing.Size(1299, 571);
            this.fld_dgcMMAllocationPlanItemsGridControl.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.fld_btnShowInventoryStock);
            this.groupBox1.Controls.Add(this.fld_lkeHRDepartmentRoomGroupItemID);
            this.groupBox1.Controls.Add(this.bosLabel5);
            this.groupBox1.Controls.Add(this.bosLabel3);
            this.groupBox1.Controls.Add(this.fld_lkeFK_HREmployeeIDReceive);
            this.groupBox1.Controls.Add(this.bosLabel2);
            this.groupBox1.Controls.Add(this.fld_btnFind);
            this.groupBox1.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.groupBox1.Controls.Add(this.fld_lkeFK_MMLineID);
            this.groupBox1.Controls.Add(this.bosLabel21);
            this.groupBox1.Controls.Add(this.bosLabel20);
            this.groupBox1.Controls.Add(this.fld_dteToDate);
            this.groupBox1.Controls.Add(this.bosLabel9);
            this.groupBox1.Controls.Add(this.fld_dteFromDate);
            this.groupBox1.Controls.Add(this.bosLabel1);
            this.groupBox1.Controls.Add(this.fld_lkeFK_MMAllocationPlanID);
            this.groupBox1.Controls.Add(this.bosLabel8);
            this.groupBox1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1299, 75);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // fld_btnShowInventoryStock
            // 
            this.fld_btnShowInventoryStock.BOSComment = null;
            this.fld_btnShowInventoryStock.BOSDataMember = null;
            this.fld_btnShowInventoryStock.BOSDataSource = null;
            this.fld_btnShowInventoryStock.BOSDescription = null;
            this.fld_btnShowInventoryStock.BOSError = null;
            this.fld_btnShowInventoryStock.BOSFieldGroup = null;
            this.fld_btnShowInventoryStock.BOSFieldRelation = null;
            this.fld_btnShowInventoryStock.BOSPrivilege = null;
            this.fld_btnShowInventoryStock.BOSPropertyName = null;
            this.fld_btnShowInventoryStock.Location = new System.Drawing.Point(976, 17);
            this.fld_btnShowInventoryStock.Name = "fld_btnShowInventoryStock";
            this.fld_btnShowInventoryStock.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShowInventoryStock, true);
            this.fld_btnShowInventoryStock.Size = new System.Drawing.Size(129, 46);
            this.fld_btnShowInventoryStock.TabIndex = 550;
            this.fld_btnShowInventoryStock.Text = "Tồn kho";
            this.fld_btnShowInventoryStock.Click += new System.EventHandler(this.fld_btnShowInventoryStock_Click);
            // 
            // fld_lkeHRDepartmentRoomGroupItemID
            // 
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSComment = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSDataMember = "FK_HRDepartmentRoomGroupItemID";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSDataSource = "MMAllocationPlans";
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
            this.fld_lkeHRDepartmentRoomGroupItemID.Location = new System.Drawing.Point(473, 21);
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
            this.fld_lkeHRDepartmentRoomGroupItemID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeHRDepartmentRoomGroupItemID.TabIndex = 548;
            this.fld_lkeHRDepartmentRoomGroupItemID.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(407, 25);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(12, 13);
            this.bosLabel5.TabIndex = 549;
            this.bosLabel5.Text = "Tổ";
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
            this.bosLabel3.Location = new System.Drawing.Point(407, 50);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(55, 13);
            this.bosLabel3.TabIndex = 547;
            this.bosLabel3.Text = "Người nhận";
            // 
            // fld_lkeFK_HREmployeeIDReceive
            // 
            this.fld_lkeFK_HREmployeeIDReceive.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeIDReceive.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeIDReceive.BOSComment = "";
            this.fld_lkeFK_HREmployeeIDReceive.BOSDataMember = "FK_HREmployeeIDReceive";
            this.fld_lkeFK_HREmployeeIDReceive.BOSDataSource = "MMAllocationPlans";
            this.fld_lkeFK_HREmployeeIDReceive.BOSDescription = null;
            this.fld_lkeFK_HREmployeeIDReceive.BOSError = null;
            this.fld_lkeFK_HREmployeeIDReceive.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeIDReceive.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeIDReceive.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeIDReceive.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeIDReceive.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeIDReceive.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeIDReceive.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeIDReceive.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeIDReceive.Location = new System.Drawing.Point(473, 47);
            this.fld_lkeFK_HREmployeeIDReceive.Name = "fld_lkeFK_HREmployeeIDReceive";
            this.fld_lkeFK_HREmployeeIDReceive.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_HREmployeeIDReceive.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeIDReceive.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeIDReceive.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeIDReceive.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeIDReceive.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeIDReceive.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ")});
            this.fld_lkeFK_HREmployeeIDReceive.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeIDReceive.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeIDReceive.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeIDReceive.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeIDReceive.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeIDReceive, true);
            this.fld_lkeFK_HREmployeeIDReceive.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_HREmployeeIDReceive.TabIndex = 546;
            this.fld_lkeFK_HREmployeeIDReceive.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(13, 23);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(68, 13);
            this.bosLabel2.TabIndex = 541;
            this.bosLabel2.Text = "Lệnh sản xuất";
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
            this.fld_btnFind.Location = new System.Drawing.Point(821, 18);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnFind, true);
            this.fld_btnFind.Size = new System.Drawing.Size(129, 45);
            this.fld_btnFind.TabIndex = 6;
            this.fld_btnFind.Text = "Tìm kiếm";
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = true;
            this.fld_lkeFK_MMWorkShopID.BOSComment = "";
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "MMWorkShops";
            this.fld_lkeFK_MMWorkShopID.BOSDescription = null;
            this.fld_lkeFK_MMWorkShopID.BOSError = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldGroup = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldParent = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldRelation = "";
            this.fld_lkeFK_MMWorkShopID.BOSPrivilege = "";
            this.fld_lkeFK_MMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMWorkShopID.BOSSelectType = "";
            this.fld_lkeFK_MMWorkShopID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMWorkShopID.CurrentDisplayText = "";
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(275, 20);
            this.fld_lkeFK_MMWorkShopID.Name = "fld_lkeFK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMWorkShopID.Properties.ColumnName = null;
            this.fld_lkeFK_MMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Tên")});
            this.fld_lkeFK_MMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeFK_MMWorkShopID.Properties.NullText = "";
            this.fld_lkeFK_MMWorkShopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 1;
            this.fld_lkeFK_MMWorkShopID.Tag = "DC";
            // 
            // fld_lkeFK_MMLineID
            // 
            this.fld_lkeFK_MMLineID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMLineID.BOSAllowDummy = true;
            this.fld_lkeFK_MMLineID.BOSComment = "";
            this.fld_lkeFK_MMLineID.BOSDataMember = "MMLineID";
            this.fld_lkeFK_MMLineID.BOSDataSource = "MMLines";
            this.fld_lkeFK_MMLineID.BOSDescription = null;
            this.fld_lkeFK_MMLineID.BOSError = null;
            this.fld_lkeFK_MMLineID.BOSFieldGroup = "";
            this.fld_lkeFK_MMLineID.BOSFieldParent = "";
            this.fld_lkeFK_MMLineID.BOSFieldRelation = "";
            this.fld_lkeFK_MMLineID.BOSPrivilege = "";
            this.fld_lkeFK_MMLineID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMLineID.BOSSelectType = "";
            this.fld_lkeFK_MMLineID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMLineID.CurrentDisplayText = "";
            this.fld_lkeFK_MMLineID.Location = new System.Drawing.Point(275, 46);
            this.fld_lkeFK_MMLineID.Name = "fld_lkeFK_MMLineID";
            this.fld_lkeFK_MMLineID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMLineID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMLineID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMLineID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMLineID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMLineID.Properties.ColumnName = null;
            this.fld_lkeFK_MMLineID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMLineName", "Tên")});
            this.fld_lkeFK_MMLineID.Properties.DisplayMember = "MMLineName";
            this.fld_lkeFK_MMLineID.Properties.NullText = "";
            this.fld_lkeFK_MMLineID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMLineID.Properties.ValueMember = "MMLineID";
            this.fld_lkeFK_MMLineID.Screen = null;
            this.fld_lkeFK_MMLineID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_MMLineID.TabIndex = 4;
            this.fld_lkeFK_MMLineID.Tag = "DC";
            // 
            // bosLabel21
            // 
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = null;
            this.bosLabel21.BOSDataSource = null;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = null;
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(222, 24);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(31, 13);
            this.bosLabel21.TabIndex = 539;
            this.bosLabel21.Text = "Xưởng";
            // 
            // bosLabel20
            // 
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = null;
            this.bosLabel20.BOSDataSource = null;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = null;
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(222, 50);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(37, 13);
            this.bosLabel20.TabIndex = 540;
            this.bosLabel20.Text = "Chuyền";
            // 
            // fld_dteToDate
            // 
            this.fld_dteToDate.BOSComment = null;
            this.fld_dteToDate.BOSDataMember = "";
            this.fld_dteToDate.BOSDataSource = "";
            this.fld_dteToDate.BOSDescription = null;
            this.fld_dteToDate.BOSError = null;
            this.fld_dteToDate.BOSFieldGroup = null;
            this.fld_dteToDate.BOSFieldRelation = null;
            this.fld_dteToDate.BOSPrivilege = null;
            this.fld_dteToDate.BOSPropertyName = null;
            this.fld_dteToDate.EditValue = null;
            this.fld_dteToDate.Location = new System.Drawing.Point(670, 46);
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(120, 20);
            this.fld_dteToDate.TabIndex = 5;
            this.fld_dteToDate.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(606, 50);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 536;
            this.bosLabel9.Text = "Đến ngày";
            // 
            // fld_dteFromDate
            // 
            this.fld_dteFromDate.BOSComment = null;
            this.fld_dteFromDate.BOSDataMember = "";
            this.fld_dteFromDate.BOSDataSource = "";
            this.fld_dteFromDate.BOSDescription = null;
            this.fld_dteFromDate.BOSError = null;
            this.fld_dteFromDate.BOSFieldGroup = null;
            this.fld_dteFromDate.BOSFieldRelation = null;
            this.fld_dteFromDate.BOSPrivilege = null;
            this.fld_dteFromDate.BOSPropertyName = null;
            this.fld_dteFromDate.EditValue = null;
            this.fld_dteFromDate.Location = new System.Drawing.Point(670, 20);
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(120, 20);
            this.fld_dteFromDate.TabIndex = 2;
            this.fld_dteFromDate.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(606, 24);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 535;
            this.bosLabel1.Text = "Từ ngày";
            // 
            // fld_lkeFK_MMAllocationPlanID
            // 
            this.fld_lkeFK_MMAllocationPlanID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMAllocationPlanID.BOSAllowDummy = false;
            this.fld_lkeFK_MMAllocationPlanID.BOSComment = null;
            this.fld_lkeFK_MMAllocationPlanID.BOSDataMember = "MMAllocationPlanID";
            this.fld_lkeFK_MMAllocationPlanID.BOSDataSource = "MMAllocationPlans";
            this.fld_lkeFK_MMAllocationPlanID.BOSDescription = null;
            this.fld_lkeFK_MMAllocationPlanID.BOSError = null;
            this.fld_lkeFK_MMAllocationPlanID.BOSFieldGroup = null;
            this.fld_lkeFK_MMAllocationPlanID.BOSFieldParent = null;
            this.fld_lkeFK_MMAllocationPlanID.BOSFieldRelation = null;
            this.fld_lkeFK_MMAllocationPlanID.BOSPrivilege = null;
            this.fld_lkeFK_MMAllocationPlanID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMAllocationPlanID.BOSSelectType = "";
            this.fld_lkeFK_MMAllocationPlanID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMAllocationPlanID.CurrentDisplayText = null;
            this.fld_lkeFK_MMAllocationPlanID.Enabled = false;
            this.fld_lkeFK_MMAllocationPlanID.Location = new System.Drawing.Point(91, 46);
            this.fld_lkeFK_MMAllocationPlanID.Name = "fld_lkeFK_MMAllocationPlanID";
            this.fld_lkeFK_MMAllocationPlanID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_MMAllocationPlanID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMAllocationPlanID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMAllocationPlanID.Properties.ColumnName = null;
            this.fld_lkeFK_MMAllocationPlanID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMAllocationPlanNo", "Mã KHSD")});
            this.fld_lkeFK_MMAllocationPlanID.Properties.DisplayMember = "MMAllocationPlanNo";
            this.fld_lkeFK_MMAllocationPlanID.Properties.NullText = "";
            this.fld_lkeFK_MMAllocationPlanID.Properties.ReadOnly = true;
            this.fld_lkeFK_MMAllocationPlanID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMAllocationPlanID.Properties.ValueMember = "MMAllocationPlanID";
            this.fld_lkeFK_MMAllocationPlanID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_MMAllocationPlanID, true);
            this.fld_lkeFK_MMAllocationPlanID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_MMAllocationPlanID.TabIndex = 3;
            this.fld_lkeFK_MMAllocationPlanID.Tag = "DC";
            this.fld_lkeFK_MMAllocationPlanID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_MMAllocationPlanID_CloseUp);
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(13, 50);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(60, 13);
            this.bosLabel8.TabIndex = 532;
            this.bosLabel8.Text = "Mã kế hoạch";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = false;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = "";
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = "BatchProductType";
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = "LumberProduct";
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Enabled = false;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(91, 20);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductSOName", "Mã đơn hàng nội bộ")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText = "";
            this.fld_lkeFK_MMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMBatchProductID.Properties.ReadOnly = true;
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 0;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_MMBatchProductID_CloseUp);
            // 
            // guiAllocationPlanItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 710);
            this.ControlBox = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fld_dgcMMAllocationPlanItemsGridControl);
            this.Controls.Add(this.fld_btnSelect);
            this.Controls.Add(this.fld_btnClose);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiAllocationPlanItems.IconOptions.Icon")));
            this.Name = "guiAllocationPlanItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiến thông tin";
            this.Load += new System.EventHandler(this.guiAllocationPlanItems_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnSelect, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMAllocationPlanItemsGridControl, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMAllocationPlanItemsGridControl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomGroupItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeIDReceive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMAllocationPlanID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnSelect;
        private BOSComponent.BOSButton fld_btnClose;
        private MMAllocationPlanItemsGridControl fld_dgcMMAllocationPlanItemsGridControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMAllocationPlanID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSDateEdit fld_dteToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteFromDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMLineID;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentRoomGroupItemID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeIDReceive;
        private BOSComponent.BOSButton fld_btnShowInventoryStock;
    }
}