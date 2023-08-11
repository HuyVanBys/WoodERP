namespace BOSERP.Modules.PurchaseProposal
{
    partial class guiChoosePurchasePlanItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChoosePurchasePlanItem));
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMPurchasePlanItems = new BOSERP.Modules.PurchaseProposal.MMPurchasePlanItemsGridControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_lkePurchasePlanID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtSearchKey = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMPurchasePlanItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePurchasePlanID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSearchKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_btnOK.Location = new System.Drawing.Point(703, 548);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(92, 27);
            this.fld_btnOK.TabIndex = 3;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
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
            this.fld_btnCancel.Location = new System.Drawing.Point(802, 548);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(92, 27);
            this.fld_btnCancel.TabIndex = 4;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dgcMMPurchasePlanItems
            // 
            this.fld_dgcMMPurchasePlanItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMPurchasePlanItems.BOSComment = null;
            this.fld_dgcMMPurchasePlanItems.BOSDataMember = null;
            this.fld_dgcMMPurchasePlanItems.BOSDataSource = "MMPurchasePlanItems";
            this.fld_dgcMMPurchasePlanItems.BOSDescription = null;
            this.fld_dgcMMPurchasePlanItems.BOSError = null;
            this.fld_dgcMMPurchasePlanItems.BOSFieldGroup = null;
            this.fld_dgcMMPurchasePlanItems.BOSFieldRelation = null;
            this.fld_dgcMMPurchasePlanItems.BOSGridType = null;
            this.fld_dgcMMPurchasePlanItems.BOSPrivilege = null;
            this.fld_dgcMMPurchasePlanItems.BOSPropertyName = null;
            this.fld_dgcMMPurchasePlanItems.CommodityType = "";
            this.fld_dgcMMPurchasePlanItems.Location = new System.Drawing.Point(12, 94);
            this.fld_dgcMMPurchasePlanItems.MenuManager = this.screenToolbar;
            this.fld_dgcMMPurchasePlanItems.Name = "fld_dgcMMPurchasePlanItems";
            this.fld_dgcMMPurchasePlanItems.PrintReport = false;
            this.fld_dgcMMPurchasePlanItems.Screen = null;
            this.fld_dgcMMPurchasePlanItems.Size = new System.Drawing.Size(882, 446);
            this.fld_dgcMMPurchasePlanItems.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.fld_lkePurchasePlanID);
            this.groupBox1.Controls.Add(this.bosLabel3);
            this.groupBox1.Controls.Add(this.fld_btnSearch);
            this.groupBox1.Controls.Add(this.bosLabel2);
            this.groupBox1.Controls.Add(this.fld_dteToDate);
            this.groupBox1.Controls.Add(this.fld_txtSearchKey);
            this.groupBox1.Controls.Add(this.bosLabel9);
            this.groupBox1.Controls.Add(this.fld_lkeMMBatchProductID);
            this.groupBox1.Controls.Add(this.bosLabel1);
            this.groupBox1.Controls.Add(this.fld_dteFromDate);
            this.groupBox1.Controls.Add(this.bosLabel8);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 76);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // fld_lkePurchasePlanID
            // 
            this.fld_lkePurchasePlanID.BOSAllowAddNew = false;
            this.fld_lkePurchasePlanID.BOSAllowDummy = true;
            this.fld_lkePurchasePlanID.BOSComment = "";
            this.fld_lkePurchasePlanID.BOSDataMember = "MMPurchasePlanID";
            this.fld_lkePurchasePlanID.BOSDataSource = "MMPurchasePlans";
            this.fld_lkePurchasePlanID.BOSDescription = null;
            this.fld_lkePurchasePlanID.BOSError = null;
            this.fld_lkePurchasePlanID.BOSFieldGroup = "";
            this.fld_lkePurchasePlanID.BOSFieldParent = "";
            this.fld_lkePurchasePlanID.BOSFieldRelation = "";
            this.fld_lkePurchasePlanID.BOSPrivilege = "";
            this.fld_lkePurchasePlanID.BOSPropertyName = "EditValue";
            this.fld_lkePurchasePlanID.BOSSelectType = "";
            this.fld_lkePurchasePlanID.BOSSelectTypeValue = "";
            this.fld_lkePurchasePlanID.CurrentDisplayText = "";
            this.fld_lkePurchasePlanID.Location = new System.Drawing.Point(80, 19);
            this.fld_lkePurchasePlanID.Name = "fld_lkePurchasePlanID";
            this.fld_lkePurchasePlanID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkePurchasePlanID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkePurchasePlanID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkePurchasePlanID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkePurchasePlanID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkePurchasePlanID.Properties.ColumnName = null;
            this.fld_lkePurchasePlanID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMPurchasePlanNo", "Mã kế hoạch")});
            this.fld_lkePurchasePlanID.Properties.DisplayMember = "MMPurchasePlanNo";
            this.fld_lkePurchasePlanID.Properties.NullText = "";
            this.fld_lkePurchasePlanID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkePurchasePlanID.Properties.ValueMember = "MMPurchasePlanID";
            this.fld_lkePurchasePlanID.Screen = null;
            this.fld_lkePurchasePlanID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkePurchasePlanID.TabIndex = 175;
            this.fld_lkePurchasePlanID.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(9, 22);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(60, 13);
            this.bosLabel3.TabIndex = 174;
            this.bosLabel3.Text = "Mã kế hoạch";
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.Location = new System.Drawing.Point(740, 42);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Size = new System.Drawing.Size(115, 23);
            this.fld_btnSearch.TabIndex = 12;
            this.fld_btnSearch.Text = "Tìm kiếm";
            this.fld_btnSearch.Click += new System.EventHandler(this.Fld_btnSearch_Click);
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
            this.bosLabel2.Location = new System.Drawing.Point(254, 48);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(39, 13);
            this.bosLabel2.TabIndex = 173;
            this.bosLabel2.Text = "Từ khóa";
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
            this.fld_dteToDate.Location = new System.Drawing.Point(561, 19);
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteToDate.TabIndex = 170;
            this.fld_dteToDate.Tag = "DC";
            // 
            // fld_txtSearchKey
            // 
            this.fld_txtSearchKey.BOSComment = null;
            this.fld_txtSearchKey.BOSDataMember = null;
            this.fld_txtSearchKey.BOSDataSource = null;
            this.fld_txtSearchKey.BOSDescription = null;
            this.fld_txtSearchKey.BOSError = null;
            this.fld_txtSearchKey.BOSFieldGroup = null;
            this.fld_txtSearchKey.BOSFieldRelation = null;
            this.fld_txtSearchKey.BOSPrivilege = null;
            this.fld_txtSearchKey.BOSPropertyName = null;
            this.fld_txtSearchKey.EditValue = "";
            this.fld_txtSearchKey.Location = new System.Drawing.Point(324, 45);
            this.fld_txtSearchKey.MenuManager = this.screenToolbar;
            this.fld_txtSearchKey.Name = "fld_txtSearchKey";
            this.fld_txtSearchKey.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.fld_txtSearchKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtSearchKey.Properties.NullValuePrompt = "Nhập vào từ khóa";
            this.fld_txtSearchKey.Properties.NullValuePromptShowForEmptyValue = true;
            this.fld_txtSearchKey.Screen = null;
            this.fld_txtSearchKey.Size = new System.Drawing.Size(387, 20);
            this.fld_txtSearchKey.TabIndex = 11;
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
            this.bosLabel9.Location = new System.Drawing.Point(495, 22);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 172;
            this.bosLabel9.Text = "Đến ngày";
            // 
            // fld_lkeMMBatchProductID
            // 
            this.fld_lkeMMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeMMBatchProductID.BOSComment = "";
            this.fld_lkeMMBatchProductID.BOSDataMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductID.BOSDescription = null;
            this.fld_lkeMMBatchProductID.BOSError = null;
            this.fld_lkeMMBatchProductID.BOSFieldGroup = "";
            this.fld_lkeMMBatchProductID.BOSFieldParent = "";
            this.fld_lkeMMBatchProductID.BOSFieldRelation = "";
            this.fld_lkeMMBatchProductID.BOSPrivilege = "";
            this.fld_lkeMMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductID.BOSSelectType = "";
            this.fld_lkeMMBatchProductID.BOSSelectTypeValue = "";
            this.fld_lkeMMBatchProductID.CurrentDisplayText = "";
            this.fld_lkeMMBatchProductID.Location = new System.Drawing.Point(80, 45);
            this.fld_lkeMMBatchProductID.Name = "fld_lkeMMBatchProductID";
            this.fld_lkeMMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX")});
            this.fld_lkeMMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeMMBatchProductID.Properties.NullText = "";
            this.fld_lkeMMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.Screen = null;
            this.fld_lkeMMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMBatchProductID.TabIndex = 167;
            this.fld_lkeMMBatchProductID.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(9, 47);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(34, 13);
            this.bosLabel1.TabIndex = 168;
            this.bosLabel1.Text = "Mã LSX";
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
            this.fld_dteFromDate.Location = new System.Drawing.Point(324, 19);
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFromDate.TabIndex = 169;
            this.fld_dteFromDate.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(253, 22);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(40, 13);
            this.bosLabel8.TabIndex = 171;
            this.bosLabel8.Text = "Từ ngày";
            // 
            // guiChoosePurchasePlanItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(902, 582);
            this.ControlBox = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fld_dgcMMPurchasePlanItems);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiChoosePurchasePlanItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách mặt hàng đề nghị";
            this.Load += new System.EventHandler(this.guiChooseProposalItem_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMPurchasePlanItems, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMPurchasePlanItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePurchasePlanID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSearchKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private MMPurchasePlanItemsGridControl fld_dgcMMPurchasePlanItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton fld_btnSearch;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteToDate;
        private BOSComponent.BOSTextBox fld_txtSearchKey;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteFromDate;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkePurchasePlanID;
    }
}