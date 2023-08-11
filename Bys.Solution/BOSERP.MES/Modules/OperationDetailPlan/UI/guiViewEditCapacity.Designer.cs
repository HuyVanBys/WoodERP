namespace BOSERP.Modules.OperationDetailPlan
{
    partial class guiViewEditCapacity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiViewEditCapacity));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcViewEditCapacityGridControl = new BOSERP.Modules.OperationDetailPlan.MMEditCapacityItemsGridControl();
            this.fld_chkAllCapacity = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_bteViewEditOperation = new BOSComponent.BOSButtonEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtSemiProductNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtSemiProductName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeICProductForBatchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_btnCreateErrorReceipt = new BOSComponent.BOSButton(this.components);
            this.fld_btnCreateReceipt = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnClear = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcViewEditCapacityGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkAllCapacity.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bteViewEditOperation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSemiProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSemiProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductForBatchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            this.bosPanel1.SuspendLayout();
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
            this.fld_btnClose.Location = new System.Drawing.Point(897, 571);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 3;
            this.fld_btnClose.Text = "Hủy";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_dgcViewEditCapacityGridControl
            // 
            this.fld_dgcViewEditCapacityGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcViewEditCapacityGridControl.BOSComment = null;
            this.fld_dgcViewEditCapacityGridControl.BOSDataMember = null;
            this.fld_dgcViewEditCapacityGridControl.BOSDataSource = "MMOperationDetailPlanCapacityItems";
            this.fld_dgcViewEditCapacityGridControl.BOSDescription = null;
            this.fld_dgcViewEditCapacityGridControl.BOSError = null;
            this.fld_dgcViewEditCapacityGridControl.BOSFieldGroup = null;
            this.fld_dgcViewEditCapacityGridControl.BOSFieldRelation = null;
            this.fld_dgcViewEditCapacityGridControl.BOSGridType = null;
            this.fld_dgcViewEditCapacityGridControl.BOSPrivilege = null;
            this.fld_dgcViewEditCapacityGridControl.BOSPropertyName = null;
            this.fld_dgcViewEditCapacityGridControl.CommodityType = "";
            this.fld_dgcViewEditCapacityGridControl.Location = new System.Drawing.Point(3, 142);
            this.fld_dgcViewEditCapacityGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcViewEditCapacityGridControl.Name = "fld_dgcViewEditCapacityGridControl";
            this.fld_dgcViewEditCapacityGridControl.PrintReport = false;
            this.fld_dgcViewEditCapacityGridControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcViewEditCapacityGridControl, true);
            this.fld_dgcViewEditCapacityGridControl.Size = new System.Drawing.Size(969, 423);
            this.fld_dgcViewEditCapacityGridControl.TabIndex = 2;
            // 
            // fld_chkAllCapacity
            // 
            this.fld_chkAllCapacity.BOSComment = null;
            this.fld_chkAllCapacity.BOSDataMember = null;
            this.fld_chkAllCapacity.BOSDataSource = null;
            this.fld_chkAllCapacity.BOSDescription = null;
            this.fld_chkAllCapacity.BOSError = null;
            this.fld_chkAllCapacity.BOSFieldGroup = null;
            this.fld_chkAllCapacity.BOSFieldRelation = null;
            this.fld_chkAllCapacity.BOSPrivilege = null;
            this.fld_chkAllCapacity.BOSPropertyName = null;
            this.fld_chkAllCapacity.Location = new System.Drawing.Point(60, 20);
            this.fld_chkAllCapacity.Name = "fld_chkAllCapacity";
            this.fld_chkAllCapacity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_chkAllCapacity.Properties.Appearance.Options.UseFont = true;
            this.fld_chkAllCapacity.Properties.Caption = "Chọn tất cả";
            this.fld_chkAllCapacity.Screen = null;
            this.fld_chkAllCapacity.Size = new System.Drawing.Size(88, 19);
            this.fld_chkAllCapacity.TabIndex = 2;
            this.fld_chkAllCapacity.CheckedChanged += new System.EventHandler(this.Fld_chkAllCapacity_CheckedChanged);
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
            this.bosLine2.Controls.Add(this.fld_bteViewEditOperation);
            this.bosLine2.Controls.Add(this.bosLabel1);
            this.bosLine2.Controls.Add(this.bosLabel3);
            this.bosLine2.Controls.Add(this.fld_txtSemiProductNo);
            this.bosLine2.Controls.Add(this.fld_txtSemiProductName);
            this.bosLine2.Controls.Add(this.fld_lkeICProductForBatchID);
            this.bosLine2.Controls.Add(this.bosLabel2);
            this.bosLine2.Controls.Add(this.fld_btnClear);
            this.bosLine2.Controls.Add(this.fld_btnFind);
            this.bosLine2.Controls.Add(this.fld_dteFromDate);
            this.bosLine2.Controls.Add(this.bosLabel6);
            this.bosLine2.Controls.Add(this.fld_dteToDate);
            this.bosLine2.Controls.Add(this.bosLabel7);
            this.bosLine2.Controls.Add(this.fld_lkeMMBatchProductID);
            this.bosLine2.Controls.Add(this.bosLabel13);
            this.bosLine2.Controls.Add(this.bosLabel12);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(3, 3);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(725, 115);
            this.bosLine2.TabIndex = 0;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Thông tin tìm kiếm";
            // 
            // fld_bteViewEditOperation
            // 
            this.fld_bteViewEditOperation.BOSComment = null;
            this.fld_bteViewEditOperation.BOSDataMember = "";
            this.fld_bteViewEditOperation.BOSDataSource = "";
            this.fld_bteViewEditOperation.BOSDescription = null;
            this.fld_bteViewEditOperation.BOSError = null;
            this.fld_bteViewEditOperation.BOSFieldGroup = null;
            this.fld_bteViewEditOperation.BOSFieldRelation = null;
            this.fld_bteViewEditOperation.BOSPrivilege = null;
            this.fld_bteViewEditOperation.BOSPropertyName = "Text";
            this.fld_bteViewEditOperation.Location = new System.Drawing.Point(83, 45);
            this.fld_bteViewEditOperation.Name = "fld_bteViewEditOperation";
            this.fld_bteViewEditOperation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bteViewEditOperation.Properties.EditFormat.FormatString = "N";
            this.fld_bteViewEditOperation.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_bteViewEditOperation.Screen = null;
            this.fld_bteViewEditOperation.Size = new System.Drawing.Size(133, 20);
            this.fld_bteViewEditOperation.TabIndex = 137;
            this.fld_bteViewEditOperation.Tag = "DC";
            this.fld_bteViewEditOperation.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Fld_bteViewEditOperation_ButtonClick);
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
            this.bosLabel1.Location = new System.Drawing.Point(251, 74);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(49, 13);
            this.bosLabel1.TabIndex = 10;
            this.bosLabel1.Text = "Mã chi tiết";
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 74);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(59, 13);
            this.bosLabel3.TabIndex = 8;
            this.bosLabel3.Text = "Thành phẩm";
            // 
            // fld_txtSemiProductNo
            // 
            this.fld_txtSemiProductNo.BOSComment = null;
            this.fld_txtSemiProductNo.BOSDataMember = null;
            this.fld_txtSemiProductNo.BOSDataSource = null;
            this.fld_txtSemiProductNo.BOSDescription = null;
            this.fld_txtSemiProductNo.BOSError = null;
            this.fld_txtSemiProductNo.BOSFieldGroup = null;
            this.fld_txtSemiProductNo.BOSFieldRelation = null;
            this.fld_txtSemiProductNo.BOSPrivilege = null;
            this.fld_txtSemiProductNo.BOSPropertyName = null;
            this.fld_txtSemiProductNo.Location = new System.Drawing.Point(330, 71);
            this.fld_txtSemiProductNo.MenuManager = this.screenToolbar;
            this.fld_txtSemiProductNo.Name = "fld_txtSemiProductNo";
            this.fld_txtSemiProductNo.Screen = null;
            this.fld_txtSemiProductNo.Size = new System.Drawing.Size(133, 20);
            this.fld_txtSemiProductNo.TabIndex = 11;
            // 
            // fld_txtSemiProductName
            // 
            this.fld_txtSemiProductName.BOSComment = null;
            this.fld_txtSemiProductName.BOSDataMember = null;
            this.fld_txtSemiProductName.BOSDataSource = null;
            this.fld_txtSemiProductName.BOSDescription = null;
            this.fld_txtSemiProductName.BOSError = null;
            this.fld_txtSemiProductName.BOSFieldGroup = null;
            this.fld_txtSemiProductName.BOSFieldRelation = null;
            this.fld_txtSemiProductName.BOSPrivilege = null;
            this.fld_txtSemiProductName.BOSPropertyName = null;
            this.fld_txtSemiProductName.Location = new System.Drawing.Point(581, 19);
            this.fld_txtSemiProductName.MenuManager = this.screenToolbar;
            this.fld_txtSemiProductName.Name = "fld_txtSemiProductName";
            this.fld_txtSemiProductName.Screen = null;
            this.fld_txtSemiProductName.Size = new System.Drawing.Size(133, 20);
            this.fld_txtSemiProductName.TabIndex = 15;
            // 
            // fld_lkeICProductForBatchID
            // 
            this.fld_lkeICProductForBatchID.BOSAllowAddNew = false;
            this.fld_lkeICProductForBatchID.BOSAllowDummy = true;
            this.fld_lkeICProductForBatchID.BOSComment = null;
            this.fld_lkeICProductForBatchID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductForBatchID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductForBatchID.BOSDescription = null;
            this.fld_lkeICProductForBatchID.BOSError = "";
            this.fld_lkeICProductForBatchID.BOSFieldGroup = null;
            this.fld_lkeICProductForBatchID.BOSFieldParent = null;
            this.fld_lkeICProductForBatchID.BOSFieldRelation = null;
            this.fld_lkeICProductForBatchID.BOSPrivilege = null;
            this.fld_lkeICProductForBatchID.BOSPropertyName = "";
            this.fld_lkeICProductForBatchID.BOSSelectType = "";
            this.fld_lkeICProductForBatchID.BOSSelectTypeValue = "";
            this.fld_lkeICProductForBatchID.CurrentDisplayText = null;
            this.fld_lkeICProductForBatchID.Location = new System.Drawing.Point(83, 71);
            this.fld_lkeICProductForBatchID.Name = "fld_lkeICProductForBatchID";
            this.fld_lkeICProductForBatchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductForBatchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductForBatchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductForBatchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductForBatchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductForBatchID.Properties.ColumnName = null;
            this.fld_lkeICProductForBatchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã thành phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FK_MMLineID", "Chuyền", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FK_MMWorkShopID", "Xưởng", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeICProductForBatchID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeICProductForBatchID.Properties.NullText = "";
            this.fld_lkeICProductForBatchID.Properties.PopupWidth = 40;
            this.fld_lkeICProductForBatchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductForBatchID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductForBatchID.Screen = null;
            this.fld_lkeICProductForBatchID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeICProductForBatchID.TabIndex = 9;
            this.fld_lkeICProductForBatchID.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(502, 22);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(53, 13);
            this.bosLabel2.TabIndex = 14;
            this.bosLabel2.Text = "Tên chi tiết";
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
            this.fld_btnFind.Location = new System.Drawing.Point(581, 48);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(133, 26);
            this.fld_btnFind.TabIndex = 18;
            this.fld_btnFind.Click += new System.EventHandler(this.Fld_btnFind_Click);
            // 
            // fld_dteFromDate
            // 
            this.fld_dteFromDate.BOSComment = "";
            this.fld_dteFromDate.BOSDataMember = "";
            this.fld_dteFromDate.BOSDataSource = "";
            this.fld_dteFromDate.BOSDescription = null;
            this.fld_dteFromDate.BOSError = null;
            this.fld_dteFromDate.BOSFieldGroup = "";
            this.fld_dteFromDate.BOSFieldRelation = "";
            this.fld_dteFromDate.BOSPrivilege = "";
            this.fld_dteFromDate.BOSPropertyName = "EditValue";
            this.fld_dteFromDate.EditValue = null;
            this.fld_dteFromDate.Location = new System.Drawing.Point(330, 19);
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteFromDate.TabIndex = 13;
            this.fld_dteFromDate.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(12, 22);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(38, 13);
            this.bosLabel6.TabIndex = 0;
            this.bosLabel6.Text = "Lệnh SX";
            // 
            // fld_dteToDate
            // 
            this.fld_dteToDate.BOSComment = "";
            this.fld_dteToDate.BOSDataMember = "";
            this.fld_dteToDate.BOSDataSource = "";
            this.fld_dteToDate.BOSDescription = null;
            this.fld_dteToDate.BOSError = null;
            this.fld_dteToDate.BOSFieldGroup = "";
            this.fld_dteToDate.BOSFieldRelation = "";
            this.fld_dteToDate.BOSPrivilege = "";
            this.fld_dteToDate.BOSPropertyName = "EditValue";
            this.fld_dteToDate.EditValue = null;
            this.fld_dteToDate.Location = new System.Drawing.Point(330, 45);
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteToDate.TabIndex = 17;
            this.fld_dteToDate.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(12, 48);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(52, 13);
            this.bosLabel7.TabIndex = 4;
            this.bosLabel7.Text = "Công đoạn";
            // 
            // fld_lkeMMBatchProductID
            // 
            this.fld_lkeMMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeMMBatchProductID.BOSComment = null;
            this.fld_lkeMMBatchProductID.BOSDataMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductID.BOSDescription = null;
            this.fld_lkeMMBatchProductID.BOSError = "";
            this.fld_lkeMMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeMMBatchProductID.BOSFieldParent = null;
            this.fld_lkeMMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeMMBatchProductID.BOSPrivilege = null;
            this.fld_lkeMMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductID.BOSSelectType = "";
            this.fld_lkeMMBatchProductID.BOSSelectTypeValue = "";
            this.fld_lkeMMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeMMBatchProductID.Location = new System.Drawing.Point(83, 19);
            this.fld_lkeMMBatchProductID.Name = "fld_lkeMMBatchProductID";
            this.fld_lkeMMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã lệnh ")});
            this.fld_lkeMMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeMMBatchProductID.Properties.NullText = "";
            this.fld_lkeMMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeMMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.Screen = null;
            this.fld_lkeMMBatchProductID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeMMBatchProductID.TabIndex = 1;
            this.fld_lkeMMBatchProductID.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(251, 48);
            this.bosLabel13.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(47, 13);
            this.bosLabel13.TabIndex = 16;
            this.bosLabel13.Text = "Đến ngày";
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
            this.bosLabel12.Location = new System.Drawing.Point(251, 22);
            this.bosLabel12.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(66, 13);
            this.bosLabel12.TabIndex = 12;
            this.bosLabel12.Text = "Ngày nhập từ";
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_btnCreateErrorReceipt);
            this.bosLine1.Controls.Add(this.fld_btnCreateReceipt);
            this.bosLine1.Controls.Add(this.fld_chkAllCapacity);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(734, 3);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(154, 115);
            this.bosLine1.TabIndex = 1;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Cập nhật thông tin";
            // 
            // fld_btnCreateErrorReceipt
            // 
            this.fld_btnCreateErrorReceipt.BOSComment = null;
            this.fld_btnCreateErrorReceipt.BOSDataMember = null;
            this.fld_btnCreateErrorReceipt.BOSDataSource = null;
            this.fld_btnCreateErrorReceipt.BOSDescription = null;
            this.fld_btnCreateErrorReceipt.BOSError = null;
            this.fld_btnCreateErrorReceipt.BOSFieldGroup = null;
            this.fld_btnCreateErrorReceipt.BOSFieldRelation = null;
            this.fld_btnCreateErrorReceipt.BOSPrivilege = null;
            this.fld_btnCreateErrorReceipt.BOSPropertyName = null;
            this.fld_btnCreateErrorReceipt.Location = new System.Drawing.Point(15, 80);
            this.fld_btnCreateErrorReceipt.Name = "fld_btnCreateErrorReceipt";
            this.fld_btnCreateErrorReceipt.Screen = null;
            this.fld_btnCreateErrorReceipt.Size = new System.Drawing.Size(133, 26);
            this.fld_btnCreateErrorReceipt.TabIndex = 3;
            this.fld_btnCreateErrorReceipt.Text = "Nhập kho hư lỗi";
            this.fld_btnCreateErrorReceipt.Click += new System.EventHandler(this.Fld_btnCreateErrorReceipt_Click);
            // 
            // fld_btnCreateReceipt
            // 
            this.fld_btnCreateReceipt.BOSComment = null;
            this.fld_btnCreateReceipt.BOSDataMember = null;
            this.fld_btnCreateReceipt.BOSDataSource = null;
            this.fld_btnCreateReceipt.BOSDescription = null;
            this.fld_btnCreateReceipt.BOSError = null;
            this.fld_btnCreateReceipt.BOSFieldGroup = null;
            this.fld_btnCreateReceipt.BOSFieldRelation = null;
            this.fld_btnCreateReceipt.BOSPrivilege = null;
            this.fld_btnCreateReceipt.BOSPropertyName = null;
            this.fld_btnCreateReceipt.Location = new System.Drawing.Point(15, 48);
            this.fld_btnCreateReceipt.Name = "fld_btnCreateReceipt";
            this.fld_btnCreateReceipt.Screen = null;
            this.fld_btnCreateReceipt.Size = new System.Drawing.Size(133, 26);
            this.fld_btnCreateReceipt.TabIndex = 3;
            this.fld_btnCreateReceipt.Text = "Tạo phiếu nhập kho";
            this.fld_btnCreateReceipt.Click += new System.EventHandler(this.Fld_btnCreateReceipt_Click);
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.bosLine2);
            this.bosPanel1.Controls.Add(this.fld_btnClose);
            this.bosPanel1.Controls.Add(this.fld_dgcViewEditCapacityGridControl);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(975, 602);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_btnClear
            // 
            this.fld_btnClear.BOSComment = null;
            this.fld_btnClear.BOSDataMember = null;
            this.fld_btnClear.BOSDataSource = null;
            this.fld_btnClear.BOSDescription = null;
            this.fld_btnClear.BOSError = null;
            this.fld_btnClear.BOSFieldGroup = null;
            this.fld_btnClear.BOSFieldRelation = null;
            this.fld_btnClear.BOSPrivilege = null;
            this.fld_btnClear.BOSPropertyName = null;
            this.fld_btnClear.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnClear.Location = new System.Drawing.Point(581, 80);
            this.fld_btnClear.Name = "fld_btnClear";
            this.fld_btnClear.Screen = null;
            this.fld_btnClear.Size = new System.Drawing.Size(133, 26);
            this.fld_btnClear.TabIndex = 18;
            this.fld_btnClear.Text = "Làm mới";
            this.fld_btnClear.Click += new System.EventHandler(this.fld_btnClear_Click);
            // 
            // guiViewEditCapacity
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(975, 602);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "guiViewEditCapacity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Danh sách chi tiết sản lượng đã nhập";
            this.Load += new System.EventHandler(this.guiViewEditCapacity_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcViewEditCapacityGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkAllCapacity.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bteViewEditOperation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSemiProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSemiProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductForBatchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private BOSComponent.BOSButton fld_btnClose;
        private MMEditCapacityItemsGridControl fld_dgcViewEditCapacityGridControl;
        private BOSComponent.BOSCheckEdit fld_chkAllCapacity;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSDateEdit fld_dteFromDate;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit fld_dteToDate;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSButton fld_btnCreateReceipt;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeICProductForBatchID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtSemiProductNo;
        private BOSComponent.BOSTextBox fld_txtSemiProductName;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSButtonEdit fld_bteViewEditOperation;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnCreateErrorReceipt;
        private BOSComponent.BOSButton fld_btnClear;
    }
}